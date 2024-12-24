using System.Collections.Generic;

public class Wheel
{
    public List<string> SectorsRu { get; private set; }
    public List<string> SectorsEn { get; private set; }

    public Wheel()
    {
        SectorsRu = new List<string>
        {
            "200", "100", "+", "100", "300", "200", "Переход хода", "100", "200", "100", "+", "100", "300", "200", "Переход хода", "100"
        };
        SectorsEn = new List<string>
        {
            "200", "100", "+", "100", "300", "200", "Skip step", "100", "200", "100", "+", "100", "300", "200", "Skip step", "100"
        };
    }
}