namespace PlayingCardsApp.Models
{
    public class Spade : PlayingCard
    {
        public Spade(int rank, string value)
        {
            this.Suit = "Spade";
            this.Rank = rank;
            this.Value = value;
        }
    }
}