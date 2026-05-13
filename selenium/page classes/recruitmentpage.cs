using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium.page_classes
{
    public class recruitmentpage : baseclass
    {
        public void AddCandidate()
        {
            var jsonData = JObject.Parse(
                File.ReadAllText("C:\\Users\\HASHAM\\source\\repos\\selenium\\selenium\\data.json"));

            string firstname = jsonData["recruitmentData"]["firstName"].ToString();
            string lastname = jsonData["recruitmentData"]["lastName"].ToString();
            string email = jsonData["recruitmentData"]["email"].ToString();
            string contactnumber = jsonData["recruitmentData"]["contactNumber"].ToString();
            string keywords = jsonData["recruitmentData"]["keywords"].ToString();

            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(15));

            // OPEN RECRUITMENT MODULE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.RecruitmentMenu))).Click();
            Thread.Sleep(2000);

            // CLICK ADD BUTTON
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.AddCandidateButton))).Click();

            // ENTER FIRST NAME
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.CandidateFirstName))).SendKeys(firstname);

            Thread.Sleep(2000);
            // ENTER LAST NAME
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.CandidateLastName))).SendKeys(lastname);


            Thread.Sleep(2000);
            // ENTER EMAIL
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.CandidateEmail))).SendKeys(email);


            Thread.Sleep(2000);
            // ENTER CONTACT NUMBER
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.CandidateContact))).SendKeys(contactnumber);

            // ENTER KEYWORDS
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.CandidateKeywords))).SendKeys(keywords);

            // CLICK SAVE BUTTON
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.SaveButton))).Click();


            Thread.Sleep(2000);
            // WAIT FOR SUCCESS MESSAGE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.SuccessMessage)));

            // VERIFY SUCCESS MESSAGE
            string actualText = chromeDriver.FindElement(
                By.XPath(locatorhelper.SuccessMessage)).Text;

            Assert.That(actualText, Is.EqualTo(
                jsonData["assertions"]["appointmentConfirmation"].ToString()),
                $"Expected '{jsonData["assertions"]["appointmentConfirmation"]}' but got '{actualText}'");
        }
    }
}