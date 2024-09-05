using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        public PlayingCard(CardSuit suit, int rank)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            string part1 = "";
            string part2 = "";
            string result = "";

            switch (rank)
            {
                case 2:
                    part1 = "2";
                    break;
                case 3:
                    part1 = "3";
                    break;
                case 4:
                    part1 = "4";
                    break;
                case 5:
                    part1 = "5";
                    break;
                case 6:
                    part1 = "6";
                    break;
                case 7:
                    part1 = "7";
                    break;
                case 8:
                    part1 = "8";
                    break;
                case 9:
                    part1 = "9";
                    break;
                case 10:
                    part1 = "10";
                    break;
                case 11:
                    part1 = "Jack";
                    break;
                case 12:
                    part1 = "Queen";
                    break;
                case 13:
                    part1 = "King";
                    break;
                case 14:
                    part1 = "Ace";
                    break;
            }

            switch (suit)
            {
                case CardSuit.Clubs:
                    part2 = "Clubs";
                    break;
                case CardSuit.Diamonds:
                    part2 = "Diamonds";
                    break;
                case CardSuit.Hearts:
                    part2 = "Hearts";
                    break;
                case CardSuit.Spades:
                    part2 = "Spades";
                    break;
            }

            result = $"{part1} of {part2}";
            return result;
        }
    }
}
