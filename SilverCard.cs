namespace MarketStore
{
    public class SilverCard : Card
    {
        private const double InitialDiscount = 2;
        private const double DiscountCap = 3.5;

        public SilverCard(double turnover)
            : base(turnover)
        {
        }

        public override double GetDiscountRate()
        {
            if (Turnover < 300)
            {
                return InitialDiscount;
            }            

            return DiscountCap;
        }
    }
}
