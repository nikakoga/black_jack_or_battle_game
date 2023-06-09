namespace GameBlackJackOrBattle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBlackjack = new RadioButton();
            btnBattle = new RadioButton();
            label1 = new Label();
            btnPass = new Button();
            btnTake = new Button();
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            lblScore1 = new Label();
            lblScore2 = new Label();
            panel1 = new Panel();
            lblCard = new Label();
            lblSumText = new Label();
            lblTurnText = new Label();
            lblTurnWho = new Label();
            lblSum = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBlackjack
            // 
            btnBlackjack.AutoSize = true;
            btnBlackjack.Location = new Point(27, 87);
            btnBlackjack.Name = "btnBlackjack";
            btnBlackjack.Size = new Size(91, 24);
            btnBlackjack.TabIndex = 0;
            btnBlackjack.TabStop = true;
            btnBlackjack.Text = "Blackjack";
            btnBlackjack.UseVisualStyleBackColor = true;
            btnBlackjack.CheckedChanged += BtnBlackjack_CheckedChanged;
            // 
            // btnBattle
            // 
            btnBattle.AutoSize = true;
            btnBattle.Location = new Point(27, 57);
            btnBattle.Name = "btnBattle";
            btnBattle.Size = new Size(69, 24);
            btnBattle.TabIndex = 1;
            btnBattle.TabStop = true;
            btnBattle.Text = "Battle";
            btnBattle.UseVisualStyleBackColor = true;
            btnBattle.CheckedChanged += BtnBattle_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "Choose your game";
            // 
            // btnPass
            // 
            btnPass.Location = new Point(625, 204);
            btnPass.Name = "btnPass";
            btnPass.Size = new Size(94, 29);
            btnPass.TabIndex = 4;
            btnPass.Text = "Pass";
            btnPass.UseVisualStyleBackColor = true;
            btnPass.Click += btnPass_Click;
            // 
            // btnTake
            // 
            btnTake.Location = new Point(625, 151);
            btnTake.Name = "btnTake";
            btnTake.Size = new Size(94, 29);
            btnTake.TabIndex = 5;
            btnTake.Text = "Take";
            btnTake.UseVisualStyleBackColor = true;
            btnTake.Click += btnTake_Click;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Location = new Point(608, 46);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(102, 20);
            lblPlayer1.TabIndex = 7;
            lblPlayer1.Text = "Player 1 Score";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Location = new Point(608, 86);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(102, 20);
            lblPlayer2.TabIndex = 8;
            lblPlayer2.Text = "Player 2 Score";
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.Location = new Point(730, 46);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(17, 20);
            lblScore1.TabIndex = 9;
            lblScore1.Text = "0";
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.Location = new Point(730, 86);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(17, 20);
            lblScore2.TabIndex = 10;
            lblScore2.Text = "0";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Card2;
            panel1.Controls.Add(lblCard);
            panel1.Location = new Point(324, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 335);
            panel1.TabIndex = 11;
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Location = new Point(94, 110);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(42, 20);
            lblCard.TabIndex = 0;
            lblCard.Text = "none";
            // 
            // lblSumText
            // 
            lblSumText.AutoSize = true;
            lblSumText.Location = new Point(358, 59);
            lblSumText.Name = "lblSumText";
            lblSumText.Size = new Size(41, 20);
            lblSumText.TabIndex = 12;
            lblSumText.Text = "Sum:";
            // 
            // lblTurnText
            // 
            lblTurnText.AutoSize = true;
            lblTurnText.Location = new Point(358, 19);
            lblTurnText.Name = "lblTurnText";
            lblTurnText.Size = new Size(41, 20);
            lblTurnText.TabIndex = 14;
            lblTurnText.Text = "Turn:";
            // 
            // lblTurnWho
            // 
            lblTurnWho.AutoSize = true;
            lblTurnWho.Location = new Point(402, 19);
            lblTurnWho.Name = "lblTurnWho";
            lblTurnWho.Size = new Size(61, 20);
            lblTurnWho.TabIndex = 15;
            lblTurnWho.Text = "Player 1";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(402, 59);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(17, 20);
            lblSum.TabIndex = 16;
            lblSum.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSum);
            Controls.Add(lblTurnWho);
            Controls.Add(lblTurnText);
            Controls.Add(lblSumText);
            Controls.Add(panel1);
            Controls.Add(lblScore2);
            Controls.Add(lblScore1);
            Controls.Add(lblPlayer2);
            Controls.Add(lblPlayer1);
            Controls.Add(btnTake);
            Controls.Add(btnPass);
            Controls.Add(label1);
            Controls.Add(btnBattle);
            Controls.Add(btnBlackjack);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton btnBlackjack;
        private RadioButton btnBattle;
        private Label label1;
        private Button btnPass;
        private Button btnTake;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Panel panel1;
        private Label lblSumText;
        private Label lblTurnText;
        public Label lblScore1;
        public Label lblScore2;
        public Label lblTurnWho;
        public Label lblSum;
        public Label lblCard;
    }
}