using System;

using System.Collections.Generic;

namespace PlayingCardsApp.Models
{
    public class Diamond : PlayingCard
    {
        public Diamond(int rank, string value)
        {
            this.Suit = "Diamond";
            this.Value = value;
            this.Rank = rank;
        }
    }
}