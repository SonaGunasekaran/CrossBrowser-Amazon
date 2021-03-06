using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CrossBrowserAmazon.Base
{
    public class Baseclass
    {
        
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
             driver = new ChromeDriver();
            driver.Url = "https://www.amazon.in/";

        }
        public void BrowserTestMethod(string browsername)
        {
            if (browsername.Equals("firefox"))
                driver = new FirefoxDriver();
            else
                driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

    }
}

