using System;
using System.Collections.Generic;
using System.Linq;

using PlayingCardsApp.Models;

namespace PlayingCardsApp.Utils
{
    public static class PlayingCardUtilities
    {
        /// <summary>
        /// The SortByRank method returns the given list of cards by rank.
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static List<PlayingCard> SortByRank(List<PlayingCard> cards)
        {
            Console.WriteLine("Given cards before sorting by rank...");
            DisplayCards(cards);
            cards = cards.OrderBy(x => x.Rank).ToList();
            Console.WriteLine("Given cards after sorting by rank...");
            DisplayCards(cards);
            return cards;
        }

        /// <summary>
        /// The SortBySuit method returns the given list of cards by suit.
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static List<PlayingCard> SortBySuit(List<PlayingCard> cards)
        {
            Console.WriteLine("Given cards before sorting by suit...");
            DisplayCards(cards);
            cards = cards.OrderBy(x => x.Suit).ToList();
            Console.WriteLine("Given cards after sorting by suit...");
            DisplayCards(cards);
            return cards;
        }

        /// <summary>
        /// The DisplayCards method takes a list of cards and displays each one.
        /// </summary>
        /// <param name="cards"></param>
        public static void DisplayCards(List<PlayingCard> cards)
        {
            foreach(PlayingCard card in cards)
            {
                card.Display();
            }
        }
    }
}
