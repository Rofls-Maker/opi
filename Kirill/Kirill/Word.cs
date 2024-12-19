public class Word
{
    public string Text { get; set; }
    public string Hint { get; set; }

    public Word(string text, string hint)
    {
        Text = text.ToUpper();
        Hint = hint;
    }
}