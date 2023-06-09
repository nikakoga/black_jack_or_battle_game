using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace GameBlackJackOrBattle
{
    public partial class Form1 : Form
    {
        BlackJackGame bjGame;

        public Form1()
        {
            InitializeComponent();

            btnPass.Visible = false;
            btnTake.Visible = false;
            lblCard.Visible = false;
            lblPlayer1.Visible = false;
            lblPlayer2.Visible = false;
            lblScore1.Visible = false;
            lblScore2.Visible = false;
            lblSum.Visible = false;
            lblSumText.Visible = false;
            lblTurnText.Visible = false;
            lblTurnWho.Visible = false;

            btnBlackjack.Checked = false;
            btnBattle.Checked = true;

        }

        private void BtnBlackjack_CheckedChanged(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            ShowBlackJackButtons();
            bjGame = new BlackJackGame(deck, this);
        }

        private void BtnBattle_CheckedChanged(object sender, EventArgs e)
        {
            Deck deck = new Deck();
        }


        private void ShowBlackJackButtons()
        {
            btnPass.Visible = true;
            btnTake.Visible = true;
            lblCard.Visible = true;
            lblPlayer1.Visible = true;
            lblPlayer2.Visible = true;
            lblScore1.Visible = true;
            lblScore2.Visible = true;
            lblSum.Visible = true;
            lblSumText.Visible = true;
            lblTurnText.Visible = true;
            lblTurnWho.Visible = true;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if (btnBlackjack.Checked)
            {
                bjGame.Pass();
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if (btnBlackjack.Checked)
            {
                bjGame.TakeCard();
            }
        }

        public void Clear()
        {
            lblCard.Text = "none";
            lblTurnWho.Text = "Player 1";
            lblScore1.Text = "0";
            lblScore2.Text = "0";
            lblSum.Text = "0";
            
        }

    }
}