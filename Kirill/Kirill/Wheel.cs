using System.Collections.Generic;

public class Wheel
{
    public List<string> Sectors { get; private set; }

    public Wheel()
    {
        Sectors = new List<string>
        {
            "100", "200", "300", "+", "Переход хода", "100", "200", "300", "+", "Переход хода"
        };
    }
}