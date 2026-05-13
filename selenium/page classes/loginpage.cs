using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using selenium;

namespace selenium.page_classes
{
    public class loginpage : baseclass
    {
        private static string jsonPath =
            "C:\\Users\\HASHAM\\source\\repos\\selenium\\selenium\\data.json";

        public void ValidLogin()
        {

            var jsonData = JObject.Parse(File.ReadAllText(jsonPath));

            string username = jsonData["loginData"]["validUsername"].ToString();
            string password = jsonData["loginData"]["validPassword"].ToString();

            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(15));

            // ENTER USERNAME
            wait.Until(d => d.FindElement(
                By.Name(locatorhelper.UserName))).SendKeys(username);

            // ENTER PASSWORD
            chromeDriver.FindElement(
                By.Name(locatorhelper.Password)).SendKeys(password);

            // CLICK LOGIN
            chromeDriver.FindElement(
                By.XPath(locatorhelper.LoginButton)).Click();

            // WAIT FOR DASHBOARD
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.DashboardText)));

            // VERIFY DASHBOARD
            string actualText = chromeDriver.FindElement(
                By.XPath(locatorhelper.DashboardText)).Text;

            Assert.That(actualText, Is.EqualTo(
                jsonData["loginData"]["dashboardText"].ToString()),
                $"Expected '{jsonData["loginData"]["dashboardText"]}' but got '{actualText}'");
        }

        public void InvalidLogin()
        {
            var jsonData = JObject.Parse(File.ReadAllText(jsonPath));

            string username = jsonData["loginData"]["invalidUsername"].ToString();
            string password = jsonData["loginData"]["invalidPassword"].ToString();

            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(15));

            // ENTER USERNAME
            wait.Until(d => d.FindElement(
                By.Name(locatorhelper.UserName))).SendKeys(username);

            // ENTER PASSWORD
            chromeDriver.FindElement(
                By.Name(locatorhelper.Password)).SendKeys(password);

            // CLICK LOGIN
            chromeDriver.FindElement(
                By.XPath(locatorhelper.LoginButton)).Click();

            // WAIT FOR ERROR MESSAGE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.InvalidLoginText)));

            // VERIFY ERROR MESSAGE
            string actualText = chromeDriver.FindElement(
                By.XPath(locatorhelper.InvalidLoginText)).Text;

            Assert.That(actualText, Is.EqualTo(
                jsonData["loginData"]["invalidLoginText"].ToString()),
                $"Expected '{jsonData["loginData"]["invalidLoginText"]}' but got '{actualText}'");
        }
    }
}