using NUnit.Framework;
using System;

namespace MarketStore.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        //Bronze card test cases
        [Test]
        public void Test1()
        {
            Card myBronzeCard = new BronzeCard(0);
            double expected = 0;
            double actual = myBronzeCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            Card myBronzeCard = new BronzeCard(100);
            double expected = 100;
            double actual = myBronzeCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            Card myBronzeCard = new BronzeCard(0);            
            double expected = 0;
            double actual = myBronzeCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            Card myBronzeCard = new BronzeCard(100);
            double expected = 1;
            double actual = myBronzeCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            Card myBronzeCard = new BronzeCard(300);
            double expected = 2.5;
            double actual = myBronzeCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test6()
        {            
            Assert.Throws<ArgumentOutOfRangeException>(() => new BronzeCard(-1));
        }

        [Test]
        public void Test7()
        {
            Card myBronzeCard = new BronzeCard(300);
            double expected = 2.5;
            double actual = myBronzeCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test8()
        {
            Card myBronzeCard = new BronzeCard(0);
            double expected = 0;
            double actual = myBronzeCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test9()
        {
            Card myBronzeCard = new BronzeCard(200);
            double expected = 1;
            double actual = myBronzeCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test10()
        {
            Card myBronzeCard = new BronzeCard(200);
            myBronzeCard.MakePurchase(150);
            double expected = 348.50;
            double actual = myBronzeCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test11()
        {
            Card myBronzeCard = new BronzeCard(200);
            Assert.Throws<ArgumentOutOfRangeException>(() => myBronzeCard.MakePurchase(-10));
        }

        //Silver card test cases

        [Test]
        public void Test12()
        {
            Card mySilverCard = new SilverCard(0);
            double expected = 0;
            double actual = mySilverCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test13()
        {
            Card mySilverCard = new SilverCard(100);
            double expected = 100;
            double actual = mySilverCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test14()
        {
            Card mySilverCard = new SilverCard(0);
            double expected = 2;
            double actual = mySilverCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test15()
        {            
            Card mySilverCard = new SilverCard(300);
            double expected = 3.5;
            double actual = mySilverCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test16()
        {
            Card mySilverCard = new SilverCard(301);
            double expected = 3.5;
            double actual = mySilverCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test17()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new SilverCard(-1));
        }

        [Test]
        public void Test18()
        {
            Card mySilverCard = new SilverCard(300);
            double expected = 3.5;
            double actual = mySilverCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test19()
        {
            Card mySilverCard = new SilverCard(0);
            double expected = 2;
            double actual = mySilverCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test20()
        {            
            Card mySilverCard = new SilverCard(300);
            double expected = 3.5;
            double actual = mySilverCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test21()
        {
            Card mySilverCard = new SilverCard(600);
            mySilverCard.MakePurchase(850);
            double expected = 1420.25;
            double actual = mySilverCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test22()
        {
            Card mySilverCard = new SilverCard(600);
            Assert.Throws<ArgumentOutOfRangeException>(() => mySilverCard.MakePurchase(-10));
        }

        //Gold card test cases

        [Test]
        public void Test23()
        {
            Card myGoldCard = new GoldCard(0);
            double expected = 0;
            double actual = myGoldCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test24()
        {
            Card myGoldCard = new GoldCard(100);
            double expected = 100;
            double actual = myGoldCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test25()
        {
            Card myGoldCard = new GoldCard(0);
            double expected = 2;
            double actual = myGoldCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test26()
        {
            Card myGoldCard = new GoldCard(100);
            double expected = 3;
            double actual = myGoldCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test27()
        {
            Card myGoldCard = new GoldCard(800);
            double expected = 10;
            double actual = myGoldCard.GetDiscountRate();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test28()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new GoldCard(-1));
        }

        [Test]
        public void Test29()
        {
            Card myGoldCard = new GoldCard(300);
            double expected = 5;
            double actual = myGoldCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test30()
        {
            Card myGoldCard = new GoldCard(0);
            double expected = 2;
            double actual = myGoldCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test31()
        {
            Card myGoldCard = new GoldCard(900);
            double expected = 10;
            double actual = myGoldCard.CalculateDiscount(100);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test32()
        {
            Card myGoldCard = new GoldCard(1500);
            myGoldCard.MakePurchase(1300);
            double expected = 2670;
            double actual = myGoldCard.Turnover;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test33()
        {
            Card myGoldCard = new GoldCard(1500);
            Assert.Throws<ArgumentOutOfRangeException>(() => myGoldCard.MakePurchase(-10));
        }
    }
}