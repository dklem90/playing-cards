using PlayingCardsApp.Data;
using PlayingCardsApp.Models;
using PlayingCardsApp.Utils;
using System;
using System.Collections.Generic;

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
        /// The CreateDeck method returns a deck of cards using the provided suits.
        /// </summary>
        /// <param name="suits"></param>
        /// <returns>List<PlayingCard> class instance</returns>
        public List<PlayingCard> CreateDeck(List<string> suits)
        {
            Console.WriteLine("Creating the deck of cards...");
            List<PlayingCard> cards = new List<PlayingCard>();
            foreach(string suit in suits)
            {
                cards.AddRange(InitializeSuit(suit));
            }
            return cards;
        }

        /// <summary>
        /// The DealCards method returns the 
        /// </summary>
        /// <param name="deckOfCards"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PlayingCard> DealCards(List<PlayingCard> deckOfCards, int count)
        {
            Console.WriteLine($"Dealing {count} cards...");
            List<PlayingCard> cards = new List<PlayingCard>();
            if(deckOfCards.Count == 0)
            {
                Console.WriteLine("Sorry, the deck is empty");
                return deckOfCards;
            }

            while(count > 0)
            {
                PlayingCard card = deckOfCards[0];
                card.Display();
                cards.Add(card);
                deckOfCards.RemoveAt(0);
                count--;
            }

            return cards;
        }

        /// <summary>
        /// The DealOneCard method returns the first card from the given deck and removes it.
        /// </summary>
        /// <param name="deckOfCards"></param>
        public PlayingCard DealOneCard(List<PlayingCard> deckOfCards)
        {
            Console.WriteLine("Dealing 1 card...");
            PlayingCard card = deckOfCards[0];
            card.Display();
            deckOfCards.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// The IntializeDeck method creates the 14 playing cards needed for each suit.
        /// </summary>
        /// <param name="suit"></param>
        /// <returns>List<PlayingCard> Class instance</returns>
        public List<PlayingCard> InitializeSuit(string suit)
        {
            List<PlayingCard> deckOfCards = new List<PlayingCard>();

            int currentRank = 13;
            for(int i = 2; i <= 10; i++)
            {
                deckOfCards.Add(Factory.CreatePlayingCard(suit, currentRank, i.ToString()));
                currentRank--;
            }

            // Add the face cards to the deck
            deckOfCards.Add(Factory.CreatePlayingCard(suit, 4, "Jack"));
            deckOfCards.Add(Factory.CreatePlayingCard(suit, 3, "Queen"));
            deckOfCards.Add(Factory.CreatePlayingCard(suit, 2, "King"));
            deckOfCards.Add(Factory.CreatePlayingCard(suit, 1, "Ace"));

            return deckOfCards;
        }

        /// <summary>
        /// The ShuffleDeck method is used to shuffle the elements of a list of PlayingCards.
        /// </summary>
        /// <param name="cards"></param>
        public void ShuffleDeck(List<PlayingCard> cards)
        {
            Console.WriteLine("Shuffling the deck...");
            Random rand = new Random();

            for(int i = 0; i < cards.Count; i++)
            {
                int cardOneIdx = rand.Next(cards.Count - 1);
                int cardTwoIdx = rand.Next(cards.Count - 1);
                Utilities.Swap(cards, cardOneIdx, cardTwoIdx);
            }
        }
    }
}