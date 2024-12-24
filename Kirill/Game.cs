using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class Game
{
    private List<Player> players;
    private int currentPlayerIndex;
    private List<Word> words;
    private Word selectedWord;
    private char[] displayedWord;
    RandomGenerator random;
    private bool gameEnded;
    private Wheel wheel;
    private string resourceNameRU = "Kirill.Resources.wordsRU.txt";

    public Game()
    {
        players = new List<Player>
        {
            new Player("1 игрок"),
            new Player("2 игрок"),
            new Player("3 игрок")
        };
        currentPlayerIndex = 0;
        random = new RandomGenerator();
        LoadWords();
        SelectRandomWord();
        wheel = new Wheel();
        gameEnded = false;
    }

    private void LoadWords()
    {
        words = new List<Word>();

        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = resourceNameRU;

        /*var resourceNames = assembly.GetManifestResourceNames(); //только для теста имеющихся ресов (для дебага)
        Console.WriteLine("Доступные ресурсы:");
        foreach (var name in resourceNames)
        {
           MessageBox.Show(name);
        }*/

        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                throw new Exception($"Ресурс '{resourceName}' не найден.");
            }

            using (StreamReader reader = new StreamReader(stream))
            {
                string content = reader.ReadToEnd();
                var lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        words.Add(new Word(parts[0].Trim(), parts[1].Trim()));
                    }
                }
            }
        }

        if (words.Count == 0)
        {
            throw new Exception("Нет слов в ресурсах.");
        }
    }

    private void SelectRandomWord()
    {
        int index = random.GenerateRandomNumber(1, words.Count);
        selectedWord = words[index];
        displayedWord = new string('_', selectedWord.Text.Length).ToCharArray();
    }

    public List<Player> Players => players;

    public string Hint => selectedWord.Hint;

    public string DisplayedWord => new string(displayedWord);

    public int CurrentPlayerIndex => currentPlayerIndex;

    public bool GameEnded => gameEnded;

    public Wheel Wheel => wheel;

    public bool RevealLetter(char letter, out int count)
    {
        count = 0;
        letter = Char.ToUpper(letter);
        for (int i = 0; i < selectedWord.Text.Length; i++)
        {
            if (selectedWord.Text[i] == letter && displayedWord[i] == '_')
            {
                displayedWord[i] = letter;
                count++;
            }
        }
        if (new string(displayedWord) == selectedWord.Text)
        {
            gameEnded = true;
        }
        return count > 0;
    }

    public bool RevealLetterByPosition(int position, out char revealedLetter)
    {
        revealedLetter = '\0';
        if (position < 1 || position > selectedWord.Text.Length)
            return false;

        if (displayedWord[position - 1] == '_')
        {
            revealedLetter = selectedWord.Text[position - 1];
            displayedWord[position - 1] = revealedLetter;
            if (new string(displayedWord) == selectedWord.Text)
            {
                gameEnded = true;
            }
            return true;
        }
        return false;
    }

    public void NextPlayer()
    {
        currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
    }
}