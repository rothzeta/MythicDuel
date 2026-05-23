namespace MythicDuel.Core.Models;

public sealed class DeterministicRandom
{
    private readonly Random _random;

    public DeterministicRandom(int seed)
    {
        Seed = seed;
        _random = new Random(seed);
    }

    public int Seed { get; }

    public int Next(int maxValue)
    {
        return _random.Next(maxValue);
    }

    public int Next(int minValue, int maxValue)
    {
        return _random.Next(minValue, maxValue);
    }

    public T Choose<T>(IReadOnlyList<T> values)
    {
        if (values.Count == 0)
        {
            throw new InvalidOperationException("Cannot choose from an empty list.");
        }

        return values[Next(values.Count)];
    }

    public void Shuffle<T>(IList<T> values)
    {
        for (var i = values.Count - 1; i > 0; i--)
        {
            var swapIndex = Next(i + 1);
            (values[i], values[swapIndex]) = (values[swapIndex], values[i]);
        }
    }
}
