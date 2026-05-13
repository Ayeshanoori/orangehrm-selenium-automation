using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium;

namespace selenium.page_classes
{
    public class dashboard: baseclass
    {

        public void VerifyDashboard()
        {

            // GET DASHBOARD TEXT

            string actualText = chromeDriver.FindElement(
                By.XPath(locatorhelper.DashboardText)).Text;



            // ASSERTION

            Assert.That(actualText, Is.EqualTo("Dashboard"),
       $"Expected 'Dashboard' but got '{actualText}'");
        }



        public void OpenPIMModule()
        {

            chromeDriver.FindElement(
                By.XPath(locatorhelper.PIMMenu)).Click();

        }



        public void OpenAdminModule()
        {

            chromeDriver.FindElement(
                By.XPath(locatorhelper.AdminMenu)).Click();

        }



        public void OpenLeaveModule()
        {

            chromeDriver.FindElement(
                By.XPath(locatorhelper.LeaveMenu)).Click();

        }



        public void OpenRecruitmentModule()
        {

            chromeDriver.FindElement(
                By.XPath(locatorhelper.RecruitmentMenu)).Click();

        }



        public void OpenMyInfoModule()
        {

            chromeDriver.FindElement(
                By.XPath(locatorhelper.MyInfoMenu)).Click();

        }

    }
}