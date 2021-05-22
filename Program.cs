using System;

using PlayingCardsApp.Models;

namespace PlayingCardsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Heart();
            card.Value = "ACE";

            Console.WriteLine(card.Suit);
            Console.WriteLine(card.Value);
        }
    }
}
