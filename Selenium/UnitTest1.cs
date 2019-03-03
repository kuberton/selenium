using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Selenium
{
    public class UnitTest1
    {
        [Fact]
        public void GoldenTest()
        {
            var driver = new ChromeDriver("./");

            // check home page has products
            driver.Navigate().GoToUrl("https://kuberton.mac-blog.org.ua/");
            Assert.True(driver.FindElementsByCssSelector(".card").Count > 0, "products on home page");

            // go to first product
            driver.FindElementsByCssSelector(".card")[0].FindElement(By.CssSelector("a")).Click();

            // add it to cart
            driver.FindElementByCssSelector("button").Click();

            driver.Navigate().GoToUrl("https://kuberton.mac-blog.org.ua/");

            // go to second product
            driver.FindElementsByCssSelector(".card")[1].FindElement(By.CssSelector("a")).Click();

            // add it to cart
            driver.FindElementByCssSelector("button").Click();

            // TODO: assert cart
            // TODO: checkout
            // TODO: assert ok


            driver.Quit();
        }
    }
}
