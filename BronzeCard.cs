namespace MarketStore
{
    public class BronzeCard : Card
    {
        private const double InitialDiscount = 0;
        private const double DiscountCap = 2.5;

        public BronzeCard(double turnover)
            : base(turnover)
        {
        }

        public override double GetDiscountRate()
        {
            if (Turnover < 100)
            {
                return InitialDiscount;
            }

            if (Turnover >= 100 && Turnover < 300)
            {
                return 1;
            }

            return DiscountCap;
        }
    }
}
