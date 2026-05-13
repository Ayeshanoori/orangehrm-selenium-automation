using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium.page_classes
{
    public class logoutpage : baseclass
    {
        public void Logout()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(15));

            // CLICK PROFILE DROPDOWN
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.ProfileDropdown))).Click();

            // CLICK LOGOUT BUTTON
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.LogoutButton))).Click();

            // WAIT FOR LOGIN PAGE
            wait.Until(d => d.FindElement(
                By.Name(locatorhelper.UserName)));

            // VERIFY LOGIN PAGE IS DISPLAYED
            string actualText = chromeDriver.FindElement(
                By.Name(locatorhelper.UserName)).GetAttribute("name");

            Assert.That(actualText, Is.EqualTo("username"),
                $"Expected 'username' but got '{actualText}'");
        }
    }
}