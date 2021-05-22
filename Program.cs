using System;

using PlayingCardsApp.Services;
using PlayingCardsApp.Models;

namespace PlayingCardsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DealerService dealer = new DealerService();
            Card card = new Club();
        }
    }
}
