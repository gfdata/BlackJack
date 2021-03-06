﻿namespace BlackJack
{
    public static class BlackJackExtensions
    {
        public static bool MustTakeCards(this CardPlayer dealer)
        {
            if (dealer == null) return false;
            if (dealer is CardDealer) 
            {
                var must = (dealer.CurrentScore < dealer.BidLimit);
                if (!must) dealer.DoneTakingCards = true;
                return must;
            }
            return false;
        }
    }
}
