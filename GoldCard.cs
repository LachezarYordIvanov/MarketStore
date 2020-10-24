namespace MarketStore
{
    public class GoldCard : Card
    {
        private const double InitialDiscount = 2;
        private const int DiscountGrowthStep = 100;
        private const double DiscountCap = 10;

        public GoldCard(double turnover)
            : base(turnover)
        {
        }

        public override double GetDiscountRate()
        {
            double discount = InitialDiscount + Turnover / DiscountGrowthStep;

            if (discount > DiscountCap)
            {
                return DiscountCap;
            }

            return discount;
        }
    }
}
