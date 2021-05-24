using System;

namespace PlayingCardsApp.Models
{
    public abstract class PlayingCard
    {
        public string Suit;
        public int Rank;
        public string Value;

        public PlayingCard() { }

        public void Display()
        {
            Console.WriteLine($"{Value} of {Suit}s");
        }

        public override bool Equals(object obj)
        {
            PlayingCard playingCard = (PlayingCard)obj;
            if(playingCard == null)
                return false;
            else
                return (Suit == playingCard.Suit && Rank == playingCard.Rank && Value == playingCard.Value);
        }

        public override int GetHashCode()
        {
            return this.Rank.GetHashCode();
        }
    }
}