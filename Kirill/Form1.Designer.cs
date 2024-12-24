using System;
using System.Drawing;
using System.Windows.Forms;

partial class Form1 : Form
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblHint;
    private System.Windows.Forms.Label lblWord;
    private System.Windows.Forms.GroupBox grpPlayers;
    private System.Windows.Forms.Label lblPlayer1;
    private System.Windows.Forms.Label lblPlayer2;
    private System.Windows.Forms.Label lblPlayer3;
    private System.Windows.Forms.Button btnEnterLetter;
    private System.Windows.Forms.TextBox txtLetter;
    private System.Windows.Forms.Label lblCurrentTurn;
    private System.Windows.Forms.PictureBox pictureBoxWheel;
    private System.Windows.Forms.Timer timerSpin;


    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHint = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnEnterLetter = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.pictureBoxWheel = new System.Windows.Forms.PictureBox();
            this.timerSpin = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.start_game = new System.Windows.Forms.Button();
            this.grpPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHint.ForeColor = System.Drawing.Color.Black;
            this.lblHint.Location = new System.Drawing.Point(12, 15);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(172, 32);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "Подсказка:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWord.ForeColor = System.Drawing.Color.Black;
            this.lblWord.Location = new System.Drawing.Point(12, 140);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(111, 32);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Слово:";
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.lblPlayer3);
            this.grpPlayers.Controls.Add(this.lblPlayer2);
            this.grpPlayers.Controls.Add(this.lblPlayer1);
            this.grpPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpPlayers.ForeColor = System.Drawing.Color.Black;
            this.grpPlayers.Location = new System.Drawing.Point(17, 239);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(250, 130);
            this.grpPlayers.TabIndex = 2;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Баланс игроков:";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayer3.Location = new System.Drawing.Point(6, 90);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(175, 25);
            this.lblPlayer3.TabIndex = 2;
            this.lblPlayer3.Text = "3 игрок: 0 очков";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2.Location = new System.Drawing.Point(6, 60);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(175, 25);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "2 игрок: 0 очков";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayer1.Location = new System.Drawing.Point(6, 30);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(175, 25);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "1 игрок: 0 очков";
            // 
            // btnEnterLetter
            // 
            this.btnEnterLetter.BackColor = System.Drawing.Color.LightGray;
            this.btnEnterLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnterLetter.ForeColor = System.Drawing.Color.Black;
            this.btnEnterLetter.Location = new System.Drawing.Point(260, 452);
            this.btnEnterLetter.Name = "btnEnterLetter";
            this.btnEnterLetter.Size = new System.Drawing.Size(240, 80);
            this.btnEnterLetter.TabIndex = 4;
            this.btnEnterLetter.Text = "Ввести букву";
            this.btnEnterLetter.UseVisualStyleBackColor = false;
            this.btnEnterLetter.Click += new System.EventHandler(this.btnEnterLetter_Click);
            // 
            // txtLetter
            // 
            this.txtLetter.BackColor = System.Drawing.Color.White;
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLetter.ForeColor = System.Drawing.Color.Black;
            this.txtLetter.Location = new System.Drawing.Point(290, 401);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(180, 45);
            this.txtLetter.TabIndex = 5;
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentTurn.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentTurn.Location = new System.Drawing.Point(12, 375);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(59, 25);
            this.lblCurrentTurn.TabIndex = 6;
            this.lblCurrentTurn.Text = "Ход:";
            // 
            // pictureBoxWheel
            // 
            this.pictureBoxWheel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWheel.Image")));
            this.pictureBoxWheel.Location = new System.Drawing.Point(410, 100);
            this.pictureBoxWheel.Name = "pictureBoxWheel";
            this.pictureBoxWheel.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWheel.TabIndex = 7;
            this.pictureBoxWheel.TabStop = false;
            // 
            // timerSpin
            // 
            this.timerSpin.Tick += new System.EventHandler(this.timerSpin_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(543, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "↓";
            // 
            // start_game
            // 
            this.start_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_game.Location = new System.Drawing.Point(230, 200);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(300, 100);
            this.start_game.TabIndex = 9;
            this.start_game.Text = "начать игру";
            this.start_game.UseVisualStyleBackColor = true;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(742, 553);
            this.Controls.Add(this.start_game);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxWheel);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnEnterLetter);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblHint);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поле чудес";
            this.grpPlayers.ResumeLayout(false);
            this.grpPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private Label label1;
    private Button start_game;
}