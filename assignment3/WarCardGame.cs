using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{

    class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();
            for (int i = 0; i < deck.allPlayingCards.Count; i = i + 2)
            {
                player1.AddCard(deck.allPlayingCards[i]);
                player2.AddCard(deck.allPlayingCards[i + 1]);
            }
        }

        public bool EndOfGame()
        {
            return ((player1.cards.Count == 0) || (player2.cards.Count == 0));
        }

        public void NextCard()
        {
            PlayingCard card1 = player1.cards[0];
            player1.cards.RemoveAt(0);
            PlayingCard card2 = player2.cards[0];
            player2.cards.RemoveAt(0);
            Console.WriteLine($"[{player1.name}] {card1.ToString()} - [{player2.name}] {card2.ToString()}");

            //wins player1
            if (card1.rank > card2.rank)
            {
                player1.AddCard(card1);
                player1.AddCard(card2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player1.name} got the cards");
                Console.ResetColor();
            }

            //wins player2
            else if (card1.rank < card2.rank)
            {
                player2.AddCard(card2);
                player2.AddCard(card1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{player2.name} got the cards");
                Console.ResetColor();
            }

            //no one wins
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"cards left [{player1.name}] {player1.cards.Count}x, [{player2.name}] {player2.cards.Count}x");
                Console.ResetColor();
            }
        }
    }
}
