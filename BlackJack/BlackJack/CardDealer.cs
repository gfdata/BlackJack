﻿using System.Linq;

namespace BlackJack
{
    public sealed class CardDealer : CardPlayer
    {
        public CardDealer() : base()
        {
            this.BidLimit = 17;
        }

        public bool IsHandOpen
        {
            get { return this.DoneTakingCards || this.HasBlackJack || this.Hand.Count > 2; }
        }

        public override string ToString()
        {
            if (this.IsHandOpen) return base.ToString();

            var cards = this.Hand.Select(q => q.ToString()).ToArray();
            for (var r = 1; r < cards.Length; r++)
            {
                cards[r] = "??";
            }
            return string.Join(", ", cards);
        }
    }
}
