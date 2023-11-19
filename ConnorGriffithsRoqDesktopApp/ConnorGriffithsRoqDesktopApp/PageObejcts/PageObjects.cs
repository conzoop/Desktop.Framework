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
        private By multiply => By.Name("Multiply by");
        private By divide => By.Name("Divide by");
        private By equals => By.Name("Equals");
        private By clear => By.Name("Clear");
        private By power => By.Name("Square");
        private By navigation => By.Name("Open Navigation");
        private By scicalcmode => By.Name("Scientific Calculator");
        #endregion

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

        public void ScientificCalculator()
        {
            _driver.FindElement(navigation).Click();
            _driver.FindElement(scicalcmode).Click();
        }
        public void PowerButton()
        {
            _driver.FindElement(power).Click();
        }

        public void Clear()
        {
            _driver.FindElement(clear).Click();
        }
        public void GetCalculatorResultTextSquare()
        {
            _driver.FindElementByName("Display is 81");
        }

        public void GetCalculatorResultTextAddition()
        {
            _driver.FindElementByName("Display is 10");
        }

        public void GetCalculatorResultTextSubtraction()
        {
            _driver.FindElementByName("Display is 6");
        }

        public void GetCalculatorResultTextMultiplication()
        {
            _driver.FindElementByName("Display is 16");
        }

        public void GetCalculatorResultTextDivision()
        {
            _driver.FindElementByName("Display is 4");
        }

        public void GetCalculatorResultTextDivisionNegative()
        {
            _driver.FindElementByName("Display is 90000000");
        }
    }
}

