namespace PlayingCardsApp.Models
{
    public class Heart : PlayingCard
    {
        public Heart(int rank, string value)
        {
            this.Suit = "Heart";
            this.Value = value;
            this.Rank = rank;
        }
    }

}