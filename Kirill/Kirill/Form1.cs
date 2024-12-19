using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

public partial class Form1 : Form
{
    private Game game;
    private int wheelValue;
    private RandomGenerator random;
    private bool isSpinning;
    private int currentRotation;
    private int spinSpeed;
    private int spinAngle;
    private int spinSteps;
    private int value;
    private string lastSpinResult;

    public Form1()
    {
        InitializeComponent();
        game = new Game();
        random = new RandomGenerator();
        currentRotation = 0;
        spinSpeed = random.GenerateRandomNumber(15,25); // начальная скорость
        spinAngle = random.GenerateRandomNumber(1,360);
        spinSteps = random.GenerateRandomNumber(0, 10);
        UpdateUI();
        StartNewRound();
    }

    private void UpdateUI()
    {
        lblHint.Text = $"Подсказка:\n {game.Hint}";
        lblWord.Text = $"Слово: {FormatDisplayedWord(game.DisplayedWord)}";
        UpdatePlayersBalance();
        lblCurrentTurn.Text = $"Ход: {game.Players[game.CurrentPlayerIndex].Name}";
    }

    private string FormatDisplayedWord(string word)
    {
        return string.Join(" ", word.ToCharArray());
    }

    private void UpdatePlayersBalance()
    {
        lblPlayer1.Text = $"{game.Players[0].Name}: {game.Players[0].Balance} очков";
        lblPlayer2.Text = $"{game.Players[1].Name}: {game.Players[1].Balance} очков";
        lblPlayer3.Text = $"{game.Players[2].Name}: {game.Players[2].Balance} очков";
    }

    private void StartSpin()
    {
        isSpinning = true;
        spinSpeed = random.GenerateRandomNumber(15, 25);
        spinSteps = random.GenerateRandomNumber(0, 10);
        timerSpin.Start();
    }

    private void timerSpin_Tick(object sender, EventArgs e)
    {
        if (spinSteps >= 50)
        {
            timerSpin.Stop();
            isSpinning = false;
            DetermineSpinResult();
            return;
        }

        if (spinSpeed > 1)
            spinSpeed--;

        currentRotation += spinSpeed;
        currentRotation %= 360;
        pictureBoxWheel.Image = Kirill.Properties.Resources.wheel.RotateImage(currentRotation);
        spinSteps++;
    }

    private void DetermineSpinResult()
    {
        // непосредственно сектор 
        int sectorCount = game.Wheel.Sectors.Count;
        double sectorAngle = 360.0 / sectorCount;
        double angle = (360 - currentRotation + sectorAngle / 2) % 360;
        int sectorIndex = (int)(angle / sectorAngle) % sectorCount;
        string result = game.Wheel.Sectors[sectorIndex];
        lastSpinResult = result;
        
        // отрисовочка 
        if (int.TryParse(result, out int value))
        {
            wheelValue = value;
            MessageBox.Show($"Выпало: {wheelValue} очков! Введите букву и нажмите 'Ввести букву'.");
        }
        else if (result == "+")
        {
            wheelValue = 0;
            MessageBox.Show($"Выпал сектор '+'. Введите номер буквы, которую хотите открыть.");
        }
        else // скип хода 
        {
            wheelValue = -1;
            MessageBox.Show("Выпал сектор 'Переход хода'. Ход переходит к следующему игроку.");
            game.NextPlayer();
            UpdateUI();
            StartNewRound();
            return;
        }
    }

    private void btnEnterLetter_Click(object sender, EventArgs e)
    {
        string input = txtLetter.Text.Trim().ToUpper();
                txtLetter.Clear();
        if (lastSpinResult == "+")
        {
                if (int.TryParse(input, out int position))
                {
                    if (game.RevealLetterByPosition(position, out char revealedLetter))
                    {
                        MessageBox.Show($"Буква на позиции {position}: {revealedLetter}");
                        game.Players[game.CurrentPlayerIndex].Balance += 100;
                    }
                    else
                    {
                        MessageBox.Show("Невозможно открыть эту букву. Возможно, она уже открыта или позиция неверна.");
                    return;
                }
                }
                else
                {
                    MessageBox.Show("Введите корректный номер буквы.");
                return;
                }
        }
        else if (int.TryParse(lastSpinResult, out value))
        {
            // Ввод буквы
            if (value > 0)
            {
                if (string.IsNullOrEmpty(input) || input.Length != 1 || !char.IsLetter(input[0]))
                {
                    MessageBox.Show("Введите одну букву.");
                    return;
                }
                char letter = input[0];
                if (game.RevealLetter(letter, out int count))
                {
                    if (wheelValue > 0)
                    {
                        game.Players[game.CurrentPlayerIndex].Balance += wheelValue * count;
                    }
                    MessageBox.Show("Есть такая буква!");
                }
                else
                {
                    MessageBox.Show("Нет такой буквы.");
                    game.NextPlayer();
                }
            }
        }

        txtLetter.Clear();
        UpdateUI();

        if (game.GameEnded)
        {
            MessageBox.Show($"Выиграл {game.Players[game.CurrentPlayerIndex].Name}! Баланс игрока: {game.Players[game.CurrentPlayerIndex].Balance} очков. Ура-ура-ура!");
            DialogResult result = MessageBox.Show("Начать новую игру?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                game = new Game();
                random = new RandomGenerator();
                UpdateUI();
                StartNewRound();
            }
            else
            {
                MessageBox.Show($"Спасибо За игру\nСтатистика за игру:\nОбщее количество заработанных очков{game.Players[0].Balance + game.Players[1].Balance+ game.Players[2].Balance}");
                this.Close();
            }
        }
        else
        {
            StartNewRound();
        }
    }

    private async void StartNewRound()
    {
        await Task.Delay(1000);
        StartSpin();
    }

}