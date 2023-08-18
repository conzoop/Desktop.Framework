using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Net.NetworkInformation;
using Driverfactory;
using SeleniumExtras;
using ConnorGriffithsRoqDesktopApp.CalculatorSteps;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium;

namespace PageObjects

{
    public class PageObject : Driver
    {
        public static Driver driverFactory = new Driver();

        public static IWebDriver _driver = GetDriver();

        #region WebElements

        private By numOne => By.Name("One");
        private By numTwo => By.Name("Two");
        private By numThree => By.Name("Three");
        private By numFour => By.Name("Four");
        private By numFive => By.Name("Five");
        private By numSix => By.Name("Six");
        private By numSeven => By.Name("Seven");
        private By numEight => By.Name("Eight");
        private By numNine => By.Name("Nine");
        private By numZero => By.Name("Zero");
        private By plus => By.Name("Plus");
        private By minus => By.Name("Minus");
        private By multiply => By.Name("Multiply By");
        private By divide => By.Name("Divide By");
        private By equals => By.Name("Equals");
        private By clear => By.Name("Clear");



        #endregion

        //private static WindowsElement header;
        //private static WindowsElement calculatorResult;

       


        public void ClickOne()
        {
            
            _driver.FindElement(numOne).Click();
        }
        public void ClickTwo()
        {
            _driver.FindElement(numTwo).Click();
        }
        public void ClickThree()
        {
            _driver.FindElement(numThree).Click();
        }
        public void ClickFour()
        {
            _driver.FindElement(numFour).Click();
        }
        public void ClickFive()
        {
            _driver.FindElement(numFive).Click();
        }
        public void ClickSix()
        {
            _driver.FindElement(numSix).Click();
        }
        public void ClickSeven()
        {
            _driver.FindElement(numSeven).Click();
        }
        public void ClickEight()
        {
            _driver.FindElement(numEight).Click();
        }
        public void ClickNine()
        {
            _driver.FindElement(numNine).Click();
        }
        public void ClickZero()
        {
            _driver.FindElement(numZero).Click();
        }
        public void ClickPlus()
        {
            _driver.FindElement(plus).Click();
        }
        public void ClickMinus()
        {
            _driver.FindElement(minus).Click();
        }
        public void ClickMultiply()
        {
            _driver.FindElement(multiply).Click();
        }
        public void ClickDivide()
        {
            _driver.FindElement(divide).Click();
        }
        public void ClickEquals()
        {
            _driver.FindElement(equals).Click();
        }        
        public void Clear()
        {
            _driver.FindElement(clear).Click();
            //Assert.AreEqual("0", GetCalculatorResultText());
        }
        //public string GetCalculatorResultText()
        //{
        //    return calculatorResult.Text.Replace("Display is", string.Empty).Trim();
        //}




        //Assert.AreEqual(expectedResult, GetCalculatorResultText());



        //public static void ClassInitialize(TestContext context)
        //{
        //    // Create _driver to launch a Calculator window
        //    Setup(context);

        //    // Identify calculator mode by locating the header
        //    try
        //    {
        //        header = _driver.FindElementByAccessibilityId("Header");
        //    }
        //    catch
        //    {
        //        header = _driver.FindElementByAccessibilityId("ContentPresenter");
        //    }

        //    // Ensure that calculator is in standard mode
        //    if (!header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase))
        //    {
        //        _driver.FindElementByAccessibilityId("TogglePaneButton").Click();
        //        Thread.Sleep(TimeSpan.FromSeconds(1));
        //        var splitViewPane = _driver.FindElementByClassName("SplitViewPane");
        //        splitViewPane.FindElementByName("Standard Calculator").Click();
        //        Thread.Sleep(TimeSpan.FromSeconds(1));
        //        Assert.IsTrue(header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase));
        //    }

        //    // Locate the calculatorResult element
        //    calculatorResult = _driver.FindElementByAccessibilityId("CalculatorResults");
        //    Assert.IsNotNull(calculatorResult);
        //}



    }
}

