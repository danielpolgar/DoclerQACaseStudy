using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Pages
{
    class HomePage
    {
        private ChromeDriver chromeDriver;
        private WebDriverWait wait;

        static string HEADER = "Welcome to the Docler Holding QA Department";
        static string PARAGRAPH = "This site is dedicated to perform some exercises and demonstrate automated web testing.";

        public HomePage(ChromeDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
            wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToTheHomePage()
        {
            chromeDriver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
        }

        public void NavigateToThe(String page)
        {
            chromeDriver.Navigate().GoToUrl(page);
        }

        public bool VerifyHeader()
        {
            return wait.Until(x => x.FindElement(By.XPath(".//h1[contains(text(),'" + HEADER + "')]"))).Displayed;
        }

        public bool VerifyParagraph()
        {
            return wait.Until(x => x.FindElement(By.XPath(".//p[contains(text(),'" + PARAGRAPH + "')]"))).Displayed;
        }

        public bool VerifyCompanyLogo()
        {
            return wait.Until(x => x.FindElement(By.Id("dh_logo"))).Displayed;
        }




    }
}