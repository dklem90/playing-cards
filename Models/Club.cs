using System;
using System.Collections.Generic;

using PlayingCardsApp.Models;

namespace PlayingCardsApp.Models
{
    public class Club : PlayingCard
    {
        public Club(int rank, string value)
        {
            this.Suit = "Club";
            this.Rank = rank;
            this.Value = value;
        }
    }
}