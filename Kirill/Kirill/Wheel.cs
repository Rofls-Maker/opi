using System;
using System.Collections.Generic;

public class Wheel
{
    public List<string> Sectors { get; private set; }
    private Random random;

    public Wheel()
    {
        Sectors = new List<string>
        {
            "100", "200", "300", "+", "Переход хода", "100", "200", "300", "+", "Переход хода"
        };
        random = new Random();
    }

    public string Spin(out int selectedSectorIndex)
    {
        // Симулируем вращение барабана
        selectedSectorIndex = random.Next(Sectors.Count);
        return Sectors[selectedSectorIndex];
    }
}