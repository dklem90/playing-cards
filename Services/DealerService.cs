using System;
using System.Linq;
using System.Collections.Generic;

using PlayingCardsApp.Models;
using PlayingCardsApp.Utils;

namespace PlayingCardsApp.Services
{
    public class DealerService
    {
        PlayingCardFactory Factory;

        public DealerService(PlayingCardFactory factory)
        {
            this.Factory = factory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suits"></param>
        /// <returns>List<PlayingCard> class instance</returns>
        public List<PlayingCard> CreateDeck(List<string> suits)
        {
            Console.WriteLine("Creating the deck of cards...");
            List<PlayingCard> cards = new List<PlayingCard>();
            foreach (string suit in suits)
            {
                cards.AddRange(InitializeDeck(suit));
            }
            return cards;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PlayingCard> DealCards(List<PlayingCard> cards, int count)
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("Sorry, the deck is empty");
                return cards;
            }

            while (count > 0)
            {
                PlayingCard card = cards[0];
                card.Display();
                cards.RemoveAt(0);
                count--;
            }

            return cards;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        public List<PlayingCard> DealOneCard(List<PlayingCard> cards)
        {
            PlayingCard card = cards[0];
            card.Display();
            cards.RemoveAt(0);
            return cards;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        public List<PlayingCard> InitializeDeck(string suit)
        {
            List<PlayingCard> cards = new List<PlayingCard>();

            int currentRank = 13;
            for (int i = 2; i <= 10; i++)
            {
                cards.Add(Factory.CreatePlayingCard(suit, currentRank, i.ToString()));
                currentRank--;
            }

            // Add the face cards to the deck
            cards.Add(Factory.CreatePlayingCard(suit, 4, "Jack"));
            cards.Add(Factory.CreatePlayingCard(suit, 3, "Queen"));
            cards.Add(Factory.CreatePlayingCard(suit, 2, "King"));
            cards.Add(Factory.CreatePlayingCard(suit, 1, "Ace"));

            return cards;
        }

        /// <summary>
        /// The ShuffleDeck method is used to shuffle the elements of a list of PlayingCards.
        /// </summary>
        /// <param name="cards"></param>
        public void ShuffleDeck(List<PlayingCard> cards)
        {
            Console.WriteLine("Shuffling the deck...");
            Random rand = new Random();

            foreach (PlayingCard card in cards)
            {
                int cardOneIdx = rand.Next(cards.Count - 1);
                int cardTwoIdx = rand.Next(cards.Count - 1);
                Utilities.Swap<PlayingCard>(cards, cardOneIdx, cardTwoIdx);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public List<PlayingCard> SortByRank(List<PlayingCard> cards)
        {
            return cards.OrderBy(x => x.Rank).ToList();
        }

        public List<PlayingCard> SortBySuit(List<PlayingCard> cards)
        {
            return cards.OrderBy(x => x.Suit).ToList();
        }
    }
}