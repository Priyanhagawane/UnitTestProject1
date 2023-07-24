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
    internal class Login_Logout
    {
       IWebDriver driver;

        public object Logout { get; private set; }

        [TestInitialize]

        [Given(@"Launch the InfoFLex")]

        [TestMethod]
        public void GivenLaunchTheInfoFLex()
        {
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Navigate().GoToUrl("http://localhost/auth/login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
        }

        [When(@"Login to InfoFlex")]

        [TestMethod]
        public void WhenLoginToInfoFlex()
        {
            driver.FindElement(By.Id("Username")).SendKeys("system");
            driver.FindElement(By.Id("Password")).SendKeys("manager");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(2000);

            //var text = driver.FindElement(By.CssSelector(".validation-summary-errors ul li")).Text;

            //Assert.AreEqual("Invalid login.", text);

            //driver.FindElement(By.XPath("/html/body/header/div/div/div[2]/ul/li[3]/a")).Click();
        }

        [When(@"User logout")]

        [TestMethod]
        public void WhenUserLogout()
         {
           driver.FindElement(By.XPath("/html/body/header/div/div/div[2]/ul/li[3]/a")).Click();
           Thread.Sleep(1000);
           driver.FindElement(By.XPath("/html/body/header/div/div/div[2]/ul/li[3]/ul/li[3]/a")).Click();

         }



    }
}
