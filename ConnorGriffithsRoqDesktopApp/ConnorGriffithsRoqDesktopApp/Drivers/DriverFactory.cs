﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace Driverfactory


{
    public class Driver
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        private static WindowsDriver<WindowsElement> _driver;

        public static WindowsDriver<WindowsElement> GetDriver()
        {
            if (_driver == null)
            {
                var appCapabilities = new AppiumOptions();
                appCapabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "WindowsPC");
                appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, CalculatorAppId);
                appCapabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Windows");

                _driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities, TimeSpan.FromSeconds(180));

                if (_driver == null)
                {
                    throw new Exception("Failed to initialize Appium driver.");
                }

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }

            return _driver;
        }

        public static void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }

        internal object FindElement(By numOne)
        {
            throw new NotImplementedException();
        }
    }
}