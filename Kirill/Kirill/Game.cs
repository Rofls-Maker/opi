using System;
using System.Collections.Generic;
using System.IO;

public class Game
{
    private List<Player> players;
    private int currentPlayerIndex;
    private List<Word> words;
    private Word selectedWord;
    private char[] displayedWord;
    private Random random;
    private bool gameEnded;
    private Wheel wheel;

    public Game()
    {
        players = new List<Player>
        {
            new Player("1 игрок"),
            new Player("2 игрок"),
            new Player("3 игрок")
        };
        currentPlayerIndex = 0;
        random = new Random();
        LoadWords();
        SelectRandomWord();
        wheel = new Wheel();
        gameEnded = false;
    }

    private void LoadWords()
    {
        words = new List<Word>();
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "words.txt");
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Файл слов не найден.");
        }

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                words.Add(new Word(parts[0].Trim(), parts[1].Trim()));
            }
        }

        if (words.Count == 0)
        {
            throw new Exception("Нет слов в файле слов.");
        }
    }

    private void SelectRandomWord()
    {
        int index = random.Next(words.Count);
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

    public string GetSelectedWord() => selectedWord.Text;
}