using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards = new List<PlayingCard>();
        public DeckOfCards()
        {
            InitCards();
        }

        private void InitCards()
        {
            foreach (CardSuit s in Enum.GetValues(typeof(CardSuit)))
            {
                for (int i = 2; i <= 14; i++)
                {
                    allPlayingCards.Add(new PlayingCard(s, i));
                }
            }
        }

        public void Print()
        {
            foreach (PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                int card1Number = rnd.Next(allPlayingCards.Count);
                int card2Number = rnd.Next(allPlayingCards.Count);
                PlayingCard card = allPlayingCards[card1Number];
                allPlayingCards[card1Number] = allPlayingCards[card2Number];
                allPlayingCards[card2Number] = card;
            }
        }
    }
}
