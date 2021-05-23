using System;

using System.Collections.Generic;

namespace PlayingCardsApp.Models
{
    public class Heart : PlayingCard
    {
        public Heart(int rank, string value)
        {
            this.Suit = "HEART";
            this.Value = value;
            this.Rank = rank;
        }
    }

}