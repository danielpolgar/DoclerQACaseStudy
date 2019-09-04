using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Pages
{
    class NavBar
    {
        private ChromeDriver chromeDriver;
        private WebDriverWait wait;

        public NavBar(ChromeDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
            wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10));
        }

        public void ClickHomeButton()
        {
            wait.Until(x => x.FindElement(By.Id("home"))).Click();
        }

        public void ClickUITestingButton()
        {
            wait.Until(x => x.FindElement(By.Id("site"))).Click();
        }

        public void ClickFormButton()
        {
            wait.Until(x => x.FindElement(By.Id("form"))).Click();
        }

        public String IsButtonStatusActive()
        {
            return wait.Until(x => x.FindElement(By.ClassName("active"))).Text;
        }

        public void ClickErrorButton()
        {
            wait.Until(x => x.FindElement(By.Id("error"))).Click();
        }
    }
}