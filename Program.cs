using System;
using System.Collections.Generic;

using PlayingCardsApp.Services;
using PlayingCardsApp.Models;

namespace PlayingCardsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DealerService dealer = new DealerService(new PlayingCardFactory());
            List<string> suits = new List<string> { "CLUB", "DIAMOND", "HEART", "SPADE" };
            List<PlayingCard> cards = dealer.CreateDeck(suits);
            dealer.ShuffleDeck(cards);
            cards = dealer.DealOneCard(cards);
            cards = dealer.DealCards(cards, 7);
        }
    }
}
