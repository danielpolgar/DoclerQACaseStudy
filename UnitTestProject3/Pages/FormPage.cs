using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Pages
{
    class FormPage
    {
        private ChromeDriver chromeDriver;
        private WebDriverWait wait;

        public FormPage(ChromeDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
            wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToTheFormPage()
        {
            chromeDriver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
        }

        public bool VerifyInputBox()
        {
            return wait.Until(x => x.FindElement(By.Id("hello-input"))).Displayed;
        }

        public bool VerifySubmitButton()
        {
            return wait.Until(x => x.FindElement(By.Id("hello-submit"))).Displayed;
        }

        public void WriteInTheInputBox(String value)
        {
            wait.Until(x => x.FindElement(By.Id("hello-input"))).SendKeys(value);
        }

        public void ClickSubmitButton()
        {
            wait.Until(x => x.FindElement(By.Id("hello-submit"))).Click();
        }

        public String GetHelloText()
        {
            return wait.Until(x => x.FindElement(By.Id("hello-text"))).Text;
        }
    }
}
