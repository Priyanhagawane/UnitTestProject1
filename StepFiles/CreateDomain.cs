using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace UnitTestProject1.StepFiles
{
    [Binding]

    [TestClass]
    internal class CreateDomain
    {
        IWebDriver driver;

        [Given(@"Open Design Management")]
        [TestInitialize]
        [TestMethod]
        public void GivenOpenDesignManagement()
        {
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Navigate().GoToUrl("http://localhost/auth/login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);

            driver.FindElement(By.Id("Username")).SendKeys("system");
            driver.FindElement(By.Id("Password")).SendKeys("manager");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//html/body/div/div[1]/div[2]/div[2]/a/div/div[1]")).Click();
            Thread.Sleep(2000);
        }


        [When(@"user create new domain")]
        [TestMethod]
        public void WhenUserCreateNewDomain()
        {
            driver.FindElement(By.Id("tbViewDataViews")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("contextMenuDomainM187")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("domainNewDomain")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(0);
         
            driver.FindElement(By.TagName("button")).Click();


            driver.SwitchTo().ActiveElement();

            //WebElement DialogHeader = (WebElement)driver.FindElement(By.XPath("/html/body/div[5]/div[1]/span"));
            //WebElement DialogBody = (WebElement)driver.FindElement(By.CssSelector("k-window-content k-dialog-content"));
            WebElement DialogOKBtn = (WebElement)driver.FindElement(By.XPath("/html/body/div[5]/div[3]/button[1]"));
            DialogOKBtn.Click();

            driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();


            //driver.SwitchTo().ActiveElement().FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();

           // driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();
            //var okBtn = driver.FindElement(By.XPath("//button[contains(text(),'OK')]"));
            //okBtn.Click(); 
        }


    }
}
