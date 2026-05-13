using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace selenium
{
    public class baseclass
    {
        public static ChromeDriver chromeDriver;

        public void DriverInitialize()
        {
            chromeDriver = new ChromeDriver();
        }

        public void OpenWindowGoToURL()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\HASHAM\\source\\repos\\selenium\\selenium\\data.json"));
            string laburl = jsonData["config"]["url"].ToString();

            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(laburl);
        }

        public void CloseBrowserWindow()
        {
            chromeDriver.Close();
        }
    }
}