using System.Collections.Generic;

public class Wheel
{
    public List<string> Sectors { get; private set; }

    public Wheel()
    {
        Sectors = new List<string>
        {
            "+", "100", "110", "120", "130", "140","Переход хода", "150", "160", "170", "180", "190", "+", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300"
        };
    }
}