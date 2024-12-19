public class Player
{
    public string Name { get; set; }
    public int Balance { get; set; }

    public Player(string name)
    {
        Name = name;
        Balance = 0;
    }
}