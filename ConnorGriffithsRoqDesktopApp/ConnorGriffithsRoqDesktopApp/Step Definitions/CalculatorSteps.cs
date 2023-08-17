using DriverFactory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjects;

namespace ConnorGriffithsRoqDesktopApp.CalculatorSteps
{
    [Binding]
    public class CalculatorSteps : PageObject  
    {
        Driver driver = new Driver();

        PageObject pageObject;


        [Given(@"I add 7 and 2")]
        public void Addition()
        {
            
            ClickSeven();
           //ClickPlus();
           // ClickTwo();
           // Assert.AreEqual("9", GetCalculatorResultText());

        }


        
    }
}
