using System.Collections.Generic;

public class Wheel
{
    public List<string> Sectors { get; private set; }

    public Wheel()
    {
        Sectors = new List<string>
        {
            "200", "100", "+", "100", "300", "200", "Переход хода", "100", "200", "100", "+", "100", "300", "200", "Переход хода", "100"
        };
    }
}