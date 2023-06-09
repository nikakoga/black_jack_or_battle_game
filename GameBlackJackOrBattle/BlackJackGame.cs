using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBlackJackOrBattle
{
    internal class BlackJackGame
    {
        Deck _deck;
        Form1 _form;
        BlackJackTurnPlayer _player1;
        BlackJackTurnPlayer _player2;

        int _currentPlayer = 1;
        
        public BlackJackGame(Deck deck, Form1 form) 
        {
            _deck = deck;
            _form = form;

            _player1 = new BlackJackTurnPlayer(_deck,_form);
            _player2 = new BlackJackTurnPlayer(_deck,_form);
        }

        public void SetWinner()
        {
            if (_player1._sum > 21 && _player2._sum > 21)
            {
                MessageBox.Show("You both loose !!!");
            }
            else if (_player1._sum > 21)
            {
                MessageBox.Show("Player 2 wins !!!");
            }
            else if (_player2._sum > 21)
            {
                MessageBox.Show("Player 1 wins !!!");
            }
            else if (_player1._sum == _player2._sum)
            {
                MessageBox.Show("Its a tie !!!");
            }
            else if (_player1._sum > _player2._sum)
            {
                MessageBox.Show("Player 1 wins !!!");
            }
            else
            {
                MessageBox.Show("Player 2 wins !!!");
            }
        }

       public void Pass()
        {
            if(_currentPlayer==1)
            {
                _currentPlayer = 2;
                _form.lblScore1.Text = _player1._sum.ToString();
                _form.lblTurnWho.Text = "Player 2";
                _form.lblSum.Text = "0";
            }
            else if(_currentPlayer == 2) 
            {
                //game finished
                _form.lblScore2.Text = _player2._sum.ToString();
                SetWinner();
                Clear();
            }
        }

        public void TakeCard()
        {
            if(_currentPlayer==1)
            {
                _player1.TakeCard();
                if(_player1._sum >= 21)
                {
                    _form.lblScore1.Text=_player1._sum.ToString();
                    Pass();
                }
            }

            if(_currentPlayer == 2)
            {
                _player2.TakeCard();
                if( _player2._sum >= 21)
                {
                    _form.lblScore2.Text = _player2._sum.ToString();
                    Pass();
                }
            }
        }

        private void Clear()
        {
            _currentPlayer = 1;
            _player1._sum = 0;
            _player2._sum = 0;
            _form.Clear();
        }
        
    }
}
