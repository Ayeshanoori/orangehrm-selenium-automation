using NUnit.Framework;
using selenium.page_classes;

namespace selenium
{
    public class tests
    {

        [Test]
        public void ValidLoginTest()
        {

            loginpage login = new loginpage();

            login.DriverInitialize();

            login.OpenWindowGoToURL();

            login.ValidLogin();

            login.CloseBrowserWindow();

        }



        [Test]
        public void InvalidLoginTest()
        {

            loginpage login = new loginpage();

            login.DriverInitialize();

            login.OpenWindowGoToURL();

            login.InvalidLogin();

            login.CloseBrowserWindow();

        }



        [Test]
        public void AddEmployeeTest()
        {

            loginpage login = new loginpage();

            pimpage pim = new pimpage();



            login.DriverInitialize();

            login.OpenWindowGoToURL();

            login.ValidLogin();



            pim.AddEmployee();



            login.CloseBrowserWindow();

        }



        [Test]
        public void RecruitmentTest()
        {

            loginpage login = new loginpage();

            recruitmentpage recruitment = new recruitmentpage();



            login.DriverInitialize();

            login.OpenWindowGoToURL();

            login.ValidLogin();



            recruitment.AddCandidate();



            login.CloseBrowserWindow();

        }





        [Test]
        public void LogoutTest()
        {

            loginpage login = new loginpage();

            logoutpage logout = new logoutpage();



            login.DriverInitialize();

            login.OpenWindowGoToURL();

            login.ValidLogin();



            logout.Logout();



            login.CloseBrowserWindow();

        }





    }
}