using OpenQA.Selenium;
using System;

namespace UnitTestProject1.StepFiles
{
    internal class SelectElement
    {
        private IWebElement webElement;

        public SelectElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        internal void SelectByIndex(int v)
        {
            throw new NotImplementedException();
        }

        internal void SelectByText(object logout)
        {
            throw new NotImplementedException();
        }
    }
}