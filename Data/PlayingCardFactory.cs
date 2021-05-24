using PlayingCardsApp.Models;
using System;

namespace PlayingCardsApp.Data
{
    public class PlayingCardFactory
    {
        /// <summary>
        /// The CreatePlayingCard method returns a playing card using the given parameters.
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public PlayingCard CreatePlayingCard(string suit, int rank, string value)
        {
            switch(suit)
            {
                case "CLUB":
                    return new Club(rank, value);
                case "DIAMOND":
                    return new Diamond(rank, value);
                case "HEART":
                    return new Heart(rank, value);
                case "SPADE":
                    return new Spade(rank, value);
                default:
                    throw new NotImplementedException("The specified suit is not yet supported");
            }
        }
    }
}