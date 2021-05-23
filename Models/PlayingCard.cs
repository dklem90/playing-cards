using System;
using System.Collections.Generic;

namespace PlayingCardsApp.Models
{
    public abstract class PlayingCard
    {
        public string Suit;
        public int Rank;
        public string Value;

        public PlayingCard() { }

        public void Display()
        {
            Console.WriteLine($"{Value} of {Suit}");
        }
    }
}