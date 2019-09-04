using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Pages;

namespace DoclerUITesting.StepBindings
{
    [Binding]
    public class StepDefinitions
    {
        private ChromeDriver chromeDriver;
        private FormPage formPage;
        private HomePage homePage;
        private NavBar navBar;

        public StepDefinitions()
        {
            chromeDriver = new ChromeDriver();
            formPage = new FormPage(chromeDriver);
            homePage = new HomePage(chromeDriver);
            navBar = new NavBar(chromeDriver);
        }

        [AfterScenario()]
        public void TearDown()
        {
            chromeDriver.Quit();
        }

        [Given(@"a web browser is at the Form page")]
        public void GivenAWebBrowserIsAtTheFormPage()
        {
            formPage.NavigateToTheFormPage();
        }

        [When(@"the user clicks on the Home button")]
        public void WhenTheUserClicksOnTheHomeButton()
        {
            navBar.ClickHomeButton();
        }

        [Then(@"the browser navigates to the home page")]
        public void ThenTheBrowserNavigatesToTheHomePage()
        {
            Assert.AreEqual(chromeDriver.Url, "http://uitest.duodecadits.com/");
        }

        [Given(@"a web browser is at the Home page")]
        public void GivenAWebBrowserIsAtTheHomePage()
        {
            homePage.NavigateToTheHomePage();
        }

        [When(@"the user clicks on the Form button")]
        public void WhenTheUserClickOnTheFormButton()
        {
            navBar.ClickFormButton();
        }

        [Then(@"the browser navigates to the Form page")]
        public void ThenTheBrowserNavigatesToTheFormPage()
        {
            Assert.AreEqual(chromeDriver.Url, "http://uitest.duodecadits.com/form.html");
        }

        [When(@"the user clicks on the UI Testing button")]
        public void WhenTheUserClicksOnTheUITestingButton()
        {
            navBar.ClickUITestingButton();
        }

        [Then(@"there is an input box and a submit button")]
        public void ThenThereIsAnInputBoxAndASubmitButton()
        {
            Assert.IsTrue(formPage.VerifyInputBox());
            Assert.IsTrue(formPage.VerifySubmitButton());
        }

        [When(@"the user writes a (.*) in the input box")]
        public void WhenTheUserWritesAInTheInputBox(string value)
        {
            formPage.WriteInTheInputBox(value);
        }

        [When(@"the user clicks on the submit button")]
        public void WhenTheUserClicksOnTheSubmitButton()
        {
            formPage.ClickSubmitButton();
        }

        [Then(@"the browser navigates to the Hello Page and displays the (.*)")]
        public void ThenTheBrowserNavigatesToTheHelloPageAndDisplaysThe(string result)
        {
            Assert.AreEqual(formPage.GetHelloText(), result);
        }

        [Given(@"the web browser is at the (.*)")]
        public void GivenTheWebBrowserIsAtThe(string page)
        {
            homePage.NavigateToThe(page);
        }

        [Then(@"the page title is UI Testing Site")]
        public void ThenThePageTitleIseUITestingSite()
        {
            Assert.AreEqual(chromeDriver.Title, "UI Testing Site");
        }

        [Then(@"the home button status is active")]
        public void ThenTheHomeButtonStatusIsActive()
        {
            Assert.AreEqual("Home", navBar.IsButtonStatusActive());
        }

        [Then(@"the form button status is active")]
        public void ThenTheFormButtonStatusIsActive()
        {
            Assert.AreEqual("Form", navBar.IsButtonStatusActive());
        }

        [Then(@"the header is showing up")]
        public void ThenTheHeaderIsShowingUp()
        {
            Assert.IsTrue(homePage.VerifyHeader());
        }

        [Then(@"the paragraph is showing up")]
        public void ThenTheParagraphIsShowingUp()
        {
            Assert.IsTrue(homePage.VerifyParagraph());
        }

        [When(@"the user clicks on the Error button")]
        public void WhenTheUserClicksOnTheErrorButton()
        {
            navBar.ClickErrorButton();
        }

        [Then(@"the page title contains Error")]
        public void ThenThePageTitleContainsError()
        {
            Assert.AreEqual(chromeDriver.Title, "404 Error: File not found :-)");
        }

        [Then(@"there is a company logo image")]
        public void ThenThereIsACompanyLogoImage()
        {
            Assert.IsTrue(homePage.VerifyCompanyLogo());
        }






    }
}
