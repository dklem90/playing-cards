using System;

using PlayingCardsApp.Models;

namespace PlayingCardsApp
{
    public class PlayingCardFactory
    {
        public PlayingCard CreatePlayingCard(string suit, int rank, string value)
        {
            switch (suit)
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