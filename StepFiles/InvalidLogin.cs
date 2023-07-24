using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject1.StepFiles
{
    [Binding]

    [TestClass]
    internal class InvalidLogin
    {
        IWebDriver driver;

        public object Logout { get; private set; }

        [TestInitialize]

        [Given(@"Launch the InfoFLex Web")]
        public void GivenLaunchTheInfoFLexWeb()
        {
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Navigate().GoToUrl("http://localhost/auth/login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
        }


        [When(@"Login with Invalid Username")]

        [TestMethod]
        public void WhenLoginWithInvalidUsername()
        {
            driver.FindElement(By.Id("Username")).SendKeys("systemm");
            driver.FindElement(By.Id("Password")).SendKeys("manager");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(2000);

            var text = driver.FindElement(By.CssSelector(".validation-summary-errors ul li")).Text;

            Assert.AreEqual("Invalid login.", text);

            driver.FindElement(By.Id("Username")).Clear();        }

        [When(@"Login with Invalid Password")]

        [TestMethod]
        public void WhenLoginWithInvalidPassword()
        {
            driver.FindElement(By.Id("Username")).SendKeys("system");
            driver.FindElement(By.Id("Password")).SendKeys("managerr");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(2000);

            var text = driver.FindElement(By.CssSelector(".validation-summary-errors ul li")).Text;

            Assert.AreEqual("Invalid login.", text);
            driver.FindElement(By.Id("Username")).Clear();
            driver.FindElement(By.Id("Password")).Clear();
        }

        [Then(@"Login with Invalid Username and Password")]

        [TestMethod]
        public void ThenLoginWithInvalidUsernameAndPassword()
        {
            driver.FindElement(By.Id("Username")).SendKeys("systemm");
            driver.FindElement(By.Id("Password")).SendKeys("managerr");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(2000);

            var text = driver.FindElement(By.CssSelector(".validation-summary-errors ul li")).Text;

            Assert.AreEqual("Invalid login.", text);
            driver.FindElement(By.Id("Username")).Clear();
            driver.FindElement(By.Id("Password")).Clear();
        }




    }
}
