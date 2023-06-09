using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBlackJackOrBattle
{
    internal class BlackJackTurnPlayer
    {
        Deck _deck;
        Form1 _form;
        public int _sum=0;
        

        public BlackJackTurnPlayer(Deck deck, Form1 form)
        {
            _deck = deck;
            _form = form;
        }

        public Card TakeCard()
        {
           var card = _deck.TakeCard(); 
            _sum += card.ValueAsInt;

            //printing on the screen points and card
            _form.lblSum.Text = _sum.ToString();
            if(card.ValueAsInt>10)
            {
                _form.lblCard.Text = card.Value + " " + card.Color;
            }
            else
            {
                _form.lblCard.Text = card.ValueAsInt + " " + card.Color;
            }
           
            return card;
        }

    }
}
