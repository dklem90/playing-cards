using System;

namespace PlayingCardsApp.Models
{
    public abstract class Card
    {
        public string Suit;

        public Card() {}
        
        public string Value { get; set; }
    }
}