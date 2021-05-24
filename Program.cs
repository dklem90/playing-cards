using PlayingCardsApp.Data;
using PlayingCardsApp.Models;
using PlayingCardsApp.Services;
using PlayingCardsApp.Utils;
using System.Collections.Generic;

namespace PlayingCardsApp
{
    class Program
    {
        static void Main()
        {
            DealerService dealer = new DealerService(new PlayingCardFactory());
            List<string> suits = new List<string> { "CLUB", "DIAMOND", "HEART", "SPADE" };
            List<PlayingCard> cards = dealer.CreateDeck(suits);
            List<PlayingCard> currentHand = new List<PlayingCard>();
            dealer.ShuffleDeck(cards);
            currentHand.Add(dealer.DealOneCard(cards));
            currentHand.AddRange(dealer.DealCards(cards, 7));
            currentHand = PlayingCardUtilities.SortByRank(currentHand);
            currentHand = PlayingCardUtilities.SortBySuit(currentHand);
        }
    }
}
