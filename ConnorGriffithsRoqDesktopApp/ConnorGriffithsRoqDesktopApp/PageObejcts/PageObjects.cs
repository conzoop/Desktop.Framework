using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Net.NetworkInformation;
using DriverFactory;

namespace PageObjects

{
    public class PageObject : Driver
    {
        Driver driver;
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

        private static WindowsElement header;
        private static WindowsElement calculatorResult;

        public void ClickOne()
        {
            driver.FindElement(numOne).Click();
        }
        public void ClickTwo()
        {
            driver.FindElement(numTwo).Click();
        }
        public void ClickThree()
        {
            driver.FindElement(numThree).Click();
        }
        public void ClickFour()
        {
            driver.FindElement(numFour).Click();
        }
        public void ClickFive()
        {
            driver.FindElement(numFive).Click();
        }
        public void ClickSix()
        {
            driver.FindElement(numSix).Click();
        }
        public void ClickSeven()
        {
            driver.FindElement(numSeven).Click();
        }
        public void ClickEight()
        {
            driver.FindElement(numEight).Click();
        }
        public void ClickNine()
        {
            driver.FindElement(numNine).Click();
        }
        public void ClickZero()
        {
            driver.FindElement(numZero).Click();
        }
        public void ClickPlus()
        {
            driver.FindElement(plus).Click();
        }
        public void ClickMinus()
        {
            driver.FindElement(minus).Click();
        }
        public void ClickMultiply()
        {
            driver.FindElement(multiply).Click();
        }
        public void ClickDivide()
        {
            driver.FindElement(divide).Click();
        }
        public void ClickEquals()
        {
            driver.FindElement(equals).Click();
        }        
        public void Clear()
        {
            driver.FindElement(clear).Click();
            Assert.AreEqual("0", GetCalculatorResultText());
        }
        public string GetCalculatorResultText()
        {
            return calculatorResult.Text.Replace("Display is", string.Empty).Trim();
        }




        //Assert.AreEqual(expectedResult, GetCalculatorResultText());



        //public static void ClassInitialize(TestContext context)
        //{
        //    // Create session to launch a Calculator window
        //    Setup(context);

        //    // Identify calculator mode by locating the header
        //    try
        //    {
        //        header = driver.FindElementByAccessibilityId("Header");
        //    }
        //    catch
        //    {
        //        header = driver.FindElementByAccessibilityId("ContentPresenter");
        //    }

        //    // Ensure that calculator is in standard mode
        //    if (!header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase))
        //    {
        //        driver.FindElementByAccessibilityId("TogglePaneButton").Click();
        //        Thread.Sleep(TimeSpan.FromSeconds(1));
        //        var splitViewPane = driver.FindElementByClassName("SplitViewPane");
        //        splitViewPane.FindElementByName("Standard Calculator").Click();
        //        Thread.Sleep(TimeSpan.FromSeconds(1));
        //        Assert.IsTrue(header.Text.Equals("Standard", StringComparison.OrdinalIgnoreCase));
        //    }

        //    // Locate the calculatorResult element
        //    calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults");
        //    Assert.IsNotNull(calculatorResult);
        //}



    }
}

