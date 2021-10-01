
using OpenQA.Selenium;

namespace CrossBrowserAmazon.Login
{
    public class LoginPage:Base.Baseclass
    {
        public static void LoginPageBrowserTest()
        {
            driver.Url = "https://www.amazon.in/";

            driver.FindElement(By.Id("nav-link-accountList")).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("email")).SendKeys("sona16061999@gmail.com");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Id("continue")).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("password")).SendKeys("Takeiteasy12#");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Id("signInSubmit")).Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
