using System.Security.Cryptography;
using System;
using System.Collections.Generic;

using PlayingCardsApp.Utils;

using PlayingCardsApp.Models;

namespace PlayingCardsApp.Services
{
    public class DealerService
    {
        public DealerService() { }

        public void CreateDeck()
        {

        }

        public void ShuffleDeck(List<Card> cardDeck)
        {
            Random rand = new Random();

            foreach (Card card in cardDeck)
            {
                int cardOneIdx = rand.Next(51);
                int cardTwoIdx = rand.Next(51);
                Utilities.Swap<Card>(cardDeck, cardOneIdx, cardTwoIdx);
            }
        }
    }
}