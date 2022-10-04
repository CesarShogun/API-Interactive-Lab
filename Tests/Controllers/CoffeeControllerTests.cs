using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;
namespace API_Interactive_Lab_1.Tests
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffeLover()
        {

            string expectedContent = "I like coffee!";

            var controller = new CoffeeController();
            var result = controller.GetSomeLove();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void TestCoffee()
        {
            var controller = new CoffeeController();
            var result = controller.Get(null);
            Assert.AreEqual("latte", result.Name);
            Assert.AreEqual(-1, result.Id);

            result = controller.Get("cappuccino");
            Assert.AreEqual("cappuccino", result.Name);
            Assert.AreEqual(2, result.Id);
        }
    }
}