using System;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Selenium
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var driver = new ChromeDriver("./");

            driver.Navigate().GoToUrl("https://kuberton.mac-blog.org.ua/");

            var btn = driver.FindElementByCssSelector("button");

            Assert.Null(btn);
            // OpenQA.Selenium.DriverServiceNotFoundException : The chromedriver file does not exist in the current directory or in a directory on the PATH environment variable. The driver can be downloaded at http://chromedriver.storage.googleapis.com/index.html.

            driver.Quit();
        }
    }
}
