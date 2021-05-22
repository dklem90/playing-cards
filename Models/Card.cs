using System;
using System.Collections.Generic;

namespace PlayingCardsApp.Models
{
    public abstract class Card
    {
        public string Suit;

        public Card() { }

        public string Value { get; set; }
        public int Rank { get; set; }

        public abstract List<Card> InitializeDeck();
    }
}