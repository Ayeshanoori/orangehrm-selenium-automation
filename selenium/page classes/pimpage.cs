using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace selenium.page_classes
{
    public class pimpage : baseclass
    {
        public void AddEmployee()
        {
            var jsonData = JObject.Parse(
                File.ReadAllText("C:\\Users\\HASHAM\\source\\repos\\selenium\\selenium\\data.json"));

            string firstname = jsonData["employeeData"][0]["firstName"].ToString();
            string middlename = jsonData["employeeData"][0]["middleName"].ToString();
            string lastname = jsonData["employeeData"][0]["lastName"].ToString();
            string employeeid = jsonData["employeeData"][0]["employeeId"].ToString();

            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(15));

            // OPEN PIM MODULE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.PIMMenu))).Click();

            Thread.Sleep(2000);
            // CLICK ADD EMPLOYEE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.AddEmployeeButton))).Click();

            // ENTER FIRST NAME
            Thread.Sleep(2000);
            wait.Until(d => d.FindElement(
                By.Name(locatorhelper.FirstName))).SendKeys(firstname);

            // ENTER MIDDLE NAME
            Thread.Sleep(2000);
            chromeDriver.FindElement(
                By.Name(locatorhelper.MiddleName)).SendKeys(middlename);

            // ENTER LAST NAME
            Thread.Sleep(2000);
            chromeDriver.FindElement(
                By.Name(locatorhelper.LastName)).SendKeys(lastname);

            // CLEAR AND ENTER EMPLOYEE ID
            var empIdField = wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.EmployeeId)));
            empIdField.Clear();
            empIdField.SendKeys(employeeid);

            // CLICK SAVE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.SaveButton))).Click();

            // WAIT FOR SUCCESS MESSAGE
            wait.Until(d => d.FindElement(
                By.XPath(locatorhelper.SuccessMessage)));

            // VERIFY SUCCESS MESSAGE
            string actualText = chromeDriver.FindElement(
                By.XPath(locatorhelper.SuccessMessage)).Text;

            Assert.That(actualText, Is.EqualTo(
                jsonData["assertions"]["employeeAddedText"].ToString()),
                $"Expected '{jsonData["assertions"]["employeeAddedText"]}' but got '{actualText}'");
        }
    }
}