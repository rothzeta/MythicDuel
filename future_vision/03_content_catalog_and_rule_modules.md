# 03 — Content Catalog and Rule Modules

## Guiding model

Use:

```text
Data-driven content
+ C# rule modules
+ stateless flyweight objects
```

Not:

```text
one class per card
full ECS framework
full scripting language
giant switch statement
```

## Content pipeline

Recommended flow:

```text
JSON/YAML/C# builder
  -> CardDefinitionSpec
  -> Catalog validation
  -> Compiled CardDefinition
  -> Runtime CardInstance
```

The spec is data.

The compiled definition may contain references to shared rule modules.

The instance contains only runtime identity/state.

## CardDefinitionSpec

Example:

```json
{
  "id": "iron.bone_cracker_cub",
  "name": "Bone-Cracker Cub",
  "factionId": "iron.hyena",
  "type": "Being",
  "level": "L1",
  "presenceCost": 1,
  "attack": 2,
  "vitality": 1,
  "tags": ["Hyena", "Pack"],
  "keywords": [
    { "id": "pack" }
  ],
  "effects": [
    {
      "id": "bonus_attack_when_attacking_damaged_shrine",
      "amount": 1
    }
  ],
  "deckbuilding": {
    "maxCopies": 4
  }
}
```

## Compiled CardDefinition

Compiled definitions are immutable.

They can contain already-resolved rule module references:

```text
CardDefinition
  Id
  Name
  Type
  Level
  FactionId
  BaseStats
  Tags
  KeywordSpecs
  EffectSpecs
  CompiledKeywords
  CompiledEffects
```

## CardInstance

A runtime `CardInstance` should not contain unique behavior objects.

It should contain:

```text
id
definition id
owner
controller
zone
damage
exhausted state
wounded state
counters
attached relic
attached possession
host id
temporary statuses
creation timestamp
```

Rule behavior comes from the catalog and active modifiers, not from local mutable closures.

## Stateless flyweight rule modules

Rule modules are shared immutable objects.

Example:

```text
WeaponMasterKeyword
FadeKeyword
PackKeyword
PierceKeyword
RecallKeyword
PreparedTacticRule
EvolutionRule
```

They should hold no per-card runtime state.

Runtime state lives in `GameState`.

A rule module receives:

```text
GameState
CardInstanceId source
ResolutionContext
```

and returns:

```text
modifiers
replacement effects
triggers
legal actions
events
state mutations through controlled appliers
```

## Rule interfaces

Recommended concepts:

```text
IKeywordModule
IEffectModule
IModifierProvider
ITriggerProvider
IReplacementProvider
IActionProvider
ICostModifier
ITargetingRule
IStaticRule
```

Do not force every mechanic into one interface.

Different rule kinds should be explicit.

## Effects

Effects are command-resolved or trigger-resolved actions.

Examples:

```text
DealDamageEffect
DrawCardsEffect
MoveCardEffect
ForgetCardEffect
SummonTokenEffect
AttachRelicEffect
AttachPossessionEffect
AddCounterEffect
GrantTemporaryKeywordEffect
PrepareTacticEffect
RecallEffect
EvolveEffect
BreakShrineEffect
ActivateAncestorEffect
```

## Keywords

Keywords can contribute different types of rules.

Example:

```text
Fade:
  contributes replacement effect:
    when this card would move to discard after resolution,
    move it to Forgotten instead.

Pack:
  contributes combat rule:
    count ready Pack Beings,
    increase max attacks up to 5,
    extra attacks beyond the normal slots must be made by Pack members.

WeaponMaster:
  contributes modifier:
    if wielding weapon, gain Pierce.

SoulSlayer:
  contributes modifier:
    if Possessed, gain Pierce.
```

## Registry/factory layer

Use registries for loading data into rule modules:

```text
KeywordRegistry
EffectRegistry
ConditionRegistry
TargetingRegistry
CardCatalog
DeckCatalog
FactionCatalog
```

Avoid stringly code in the core.

Strings can appear in content files, but should be converted to typed IDs during catalog compilation.

## Catalog validation

The content layer should validate:

```text
all referenced cards exist
all deck cards exist
all keyword IDs exist
all effect IDs exist
faction IDs exist
evolution targets exist
L2 evolves from legal L1
L3 evolves from legal L2
unique card duplicate rules
max copies
presence costs are valid
attack/vitality are in legal range
keyword parameters are valid
effect parameters are valid
```

Run catalog validation in tests and at startup.

## No full scripting language yet

A full card DSL is premature.

Use data for common structure and C# for mechanics.

Only consider a DSL when:

```text
you have many repeated effect patterns
you have enough cards to know the grammar
design iteration is blocked by C# code changes
you want non-programmers to author complex cards
```

Until then:

```text
JSON + C# effect registry
```

is the right level.
