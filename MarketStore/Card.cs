using System;

namespace MarketStore
{
    public abstract class Card
    {
        private const string TurnoverOutOfRangeExeptionMessage = "Turnover can't be negative!";
        private const string ValueOfPurchaseOutOfRangeExeptionMessage = "Value of purchase can't be negative or zero!";
        
        public Card(double turnover)
        {            
            this.Turnover = turnover;

            if (turnover < 0)
            {
                throw new ArgumentOutOfRangeException(TurnoverOutOfRangeExeptionMessage);
            }
        }

        public abstract double GetDiscountRate();

        public double Turnover { get; set; }

        public double calculateDiscount(double valueOfPurchase)
        {
            return valueOfPurchase * GetDiscountRate() / 100;
        }

        public void MakePurchase(double valueOfPurchase)
        {
            if (valueOfPurchase <= 0)
            {
                throw new ArgumentOutOfRangeException(ValueOfPurchaseOutOfRangeExeptionMessage);
            }

            Purchase purchase = new Purchase(valueOfPurchase, this);

            Turnover += purchase.Total;

            PrintReceipt(purchase);
        }

        private void PrintReceipt(Purchase purchase)
        {
            Console.WriteLine($"Purchase value: ${purchase.ValueOfPurchase:F2}");

            Console.WriteLine($"Discount rate: {purchase.DiscountRate:F1}%");

            Console.WriteLine($"Discount: ${purchase.Discount:F2}");

            Console.WriteLine($"Total: ${purchase.Total:F2}");

            Console.WriteLine();
        }
    }
}
