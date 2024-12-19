partial class Form1
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
            this.grpPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(12, 9);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(81, 16);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "Подсказка:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWord.Location = new System.Drawing.Point(12, 40);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(101, 31);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Слово:";
            // 
            // grpPlayers
            // 
            this.grpPlayers.Controls.Add(this.lblPlayer3);
            this.grpPlayers.Controls.Add(this.lblPlayer2);
            this.grpPlayers.Controls.Add(this.lblPlayer1);
            this.grpPlayers.Location = new System.Drawing.Point(16, 80);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(200, 100);
            this.grpPlayers.TabIndex = 2;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Баланс игроков:";
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(6, 70);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(109, 16);
            this.lblPlayer3.TabIndex = 2;
            this.lblPlayer3.Text = "3 игрок: 0 очков";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(6, 45);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(109, 16);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "2 игрок: 0 очков";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(6, 20);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(109, 16);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "1 игрок: 0 очков";
            // 
            // btnEnterLetter
            // 
            this.btnEnterLetter.Location = new System.Drawing.Point(250, 160);
            this.btnEnterLetter.Name = "btnEnterLetter";
            this.btnEnterLetter.Size = new System.Drawing.Size(150, 30);
            this.btnEnterLetter.TabIndex = 4;
            this.btnEnterLetter.Text = "Ввести букву";
            this.btnEnterLetter.UseVisualStyleBackColor = true;
            this.btnEnterLetter.Click += new System.EventHandler(this.btnEnterLetter_Click);
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(250, 120);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(150, 22);
            this.txtLetter.TabIndex = 5;
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Location = new System.Drawing.Point(12, 200);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(34, 16);
            this.lblCurrentTurn.TabIndex = 6;
            this.lblCurrentTurn.Text = "Ход:";
            // 
            // pictureBoxWheel
            // 
            this.pictureBoxWheel.Image = global::Kirill.Properties.Resources.wheel;
            this.pictureBoxWheel.Location = new System.Drawing.Point(250, 200);
            this.pictureBoxWheel.Name = "pictureBoxWheel";
            this.pictureBoxWheel.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWheel.TabIndex = 7;
            this.pictureBoxWheel.TabStop = false;
            // 
            // timerSpin
            // 
            this.timerSpin.Tick += new System.EventHandler(this.timerSpin_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 421);
            this.Controls.Add(this.pictureBoxWheel);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnEnterLetter);
            this.Controls.Add(this.grpPlayers);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblHint);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 468);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Поле чудес";
            this.grpPlayers.ResumeLayout(false);
            this.grpPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}