using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBlackJackOrBattle
{
    internal class Deck
    {
        List<Card> deck = new List<Card>();

        public Deck()
        {
            CreateDeck();
        }


        public Card TakeCard()
        {
            if(deck.Count == 0)
            {
                CreateDeck();
            }
            var card = deck.First();
            deck.Remove(card);
            return card;
        }

        private void CreateDeck()
        {
            List<string> cardColours = new List<string>() { "club", "spade", "heart", "diamond" };

            foreach (string colour in cardColours)
            {
                foreach (CardValue e in Enum.GetValues(typeof(CardValue)))
                {
                    Card card = new Card(e, colour);
                    deck.Add(card);
                }
            }
            Shuffle(deck);
        }

        private void Shuffle(List<Card> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
 }

