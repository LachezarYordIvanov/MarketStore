namespace MarketStore
{
    public class Purchase
    {
        public Purchase(double valueOfPurchase, Card card)
        {
            this.ValueOfPurchase = valueOfPurchase;            

            this.DiscountRate = card.GetDiscountRate();

            this.Discount = card.CalculateDiscount(valueOfPurchase);

            this.Total = valueOfPurchase - this.Discount;
        }

        public double DiscountRate { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public double ValueOfPurchase { get; set; }
    }
}
