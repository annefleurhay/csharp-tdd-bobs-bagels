using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
using tdd_bobs_bagels.CSharp.Main;

namespace tdd_bobs_bagels.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void Add()
        {
            Basket basket = new Basket();

            //basket.bagels.Add("Bacon");
            basket.AddBagel("Bacon");

            Assert.IsTrue(1 == basket.bagels.Count());
            
        }
        [Test]
        public void Remove()
        {
            Basket basket = new Basket();

            basket.bagels.Add("Bacon");
            //basket.RemoveBagel("Bacon");
            bool result = basket.RemoveBagel("Bacon");
            //Assert.IsTrue(0 == basket.bagels.Count());
            Assert.IsTrue(result);

        }
        [Test]
        public void Maximum()
        {
            Basket basket = new Basket();

            basket.bagels.Add("Bacon");
            basket.bagels.Add("Salmon");
            basket.bagels.Add("Nutella");
            basket.bagels.Add("Onion");
            bool result = basket.AddBagel("Cheese");

            Assert.IsFalse(result);

        }

        [Test]
        public void NotFound()
        {
            Basket basket = new Basket();

            basket.bagels.Add("Bacon");
            basket.bagels.Add("Salmon");

            string result = basket.RemoveBagelMessage("Cheese");

            Assert.IsTrue(result == "Your bagel has not been found");
        }
    }
}