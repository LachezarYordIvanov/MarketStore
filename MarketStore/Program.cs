using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Card myBronzeCard = new BronzeCard(0);
                myBronzeCard.MakePurchase(150);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);                
            }

            try
            {
                Card mySilverCard = new SilverCard(600);
                mySilverCard.MakePurchase(850);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Card myGoldCard = new GoldCard(1500);
                myGoldCard.MakePurchase(1300);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
