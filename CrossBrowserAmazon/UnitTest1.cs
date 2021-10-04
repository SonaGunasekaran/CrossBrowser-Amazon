using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CrossBrowserAmazon
{
    [TestFixture]
    [Parallelizable]
    public class Tests : Base.Baseclass
    {
        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "chrome", "firefox" };
            foreach (string b in browsers)
            {
                yield return b;
            }
        }

        [Test]
        [TestCaseSource("BrowserToRunWith")]
        public void TestForLoginPage(string browsername)
        {
            BrowserTestMethod(browsername);
            Login.LoginPage.LoginPageBrowserTest();
        }

        [Test]
        public void TestForProductAndRating()
        {
            ProductsAndRatings.ProductAndRatingAction.GetProductAndRating();
        }
    }
}