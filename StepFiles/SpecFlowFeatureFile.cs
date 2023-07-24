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
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.StepFiles
{
    [Binding]

    [TestClass]

    public class SpecFlowFeatureFile
    {
       IWebDriver driver;

       [TestInitialize]

        [Given(@"Launch the InfoFlex")]

        [TestMethod]
        public void GivenLaunchTheInfoFlex()
        {
            driver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");
            driver.Navigate().GoToUrl("http://localhost/auth/login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();
            
            Thread.Sleep(3000);
        }

        [When(@"User login")]

        [TestMethod]
        public void WhenUserLogin()
        {
            driver.FindElement(By.Id("Username")).SendKeys("system");        
            driver.FindElement(By.Id("Password")).SendKeys("manager");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();         
        }

        [Given(@"click Design Management")]

        [TestMethod]
        public void GivenClickDesignManagement()
        {
            driver.FindElement(By.Id("Username")).SendKeys("system");
            driver.FindElement(By.Id("Password")).SendKeys("manager");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//html/body/div/div[1]/div[2]/div[2]/a/div/div[1]")).Click();
            
        }

        [When(@"click on Design Management New window should be opened")]

        [TestMethod]
        public void WhenClickOnDesignManagementNewWindowShouldBeOpened()
        {
            driver.FindElement(By.Id("Username")).SendKeys("system");
            driver.FindElement(By.Id("Password")).SendKeys("manager");
            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//html/body/div/div[1]/div[2]/div[2]/a/div/div[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("tbViewDataViews")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[1]/div[2]/div/ul/li[10]/div/span[1]/span")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[1]/div[2]/div/ul/li[10]/div/span[2]/input")).Click();
            driver.FindElement(By.Id("tbShowItems")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("contextMenuRightDomainM182")).Click();
            driver.FindElement(By.Id("rcwEditDefinitionDomain")).Click();
            Thread.Sleep(000);
            //driver.FindElement(By.ClassName("btn btn-danger")).Click();

        }



    }
}
