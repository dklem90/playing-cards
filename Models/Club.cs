using System;
using System.Collections.Generic;

namespace PlayingCardsApp.Models
{
    public class Club : Card
    {
        public Club(string value, int rank)
        {
            this.Suit = "CLUB";
            this.Value = value;
            this.Rank = rank;
        }

        public override List<Card> InitializeDeck()
        {
            List<Card> cards = new List<Card>();

            // Add the face cards to the deck
            cards.Add(new Club("Jack", 4));
            cards.Add(new Club("Queen", 3));
            cards.Add(new Club("King", 2));
            cards.Add(new Club("Ace", 1));

            int currentRank = 14;
            for (int i = 2; i <= 10; i++)
            {
                cards.Add(new Club(i.ToString(), currentRank));
                currentRank--;
            }

            foreach (Card card in cards)
            {
                Console.WriteLine(card.Suit);
                Console.WriteLine(card.Value);
                Console.WriteLine(card.Rank);
            }

            return cards;
        }
    }
}