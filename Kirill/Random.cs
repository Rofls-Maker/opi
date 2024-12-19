using System;

public class RandomGenerator
{
    private Random _random;

    public RandomGenerator()
    {
        _random = new Random(DateTime.Now.Millisecond);
    }

    public int GenerateRandomNumber(int min = 100, int max = 300)
    {
        if (min >= max)
            throw new ArgumentOutOfRangeException("max", "max должен быть больше min.");

        return _random.Next(min, max + 1);
    }
}