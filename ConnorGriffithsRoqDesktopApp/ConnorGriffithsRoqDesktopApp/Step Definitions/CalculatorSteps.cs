using Driverfactory;
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
        //_driver

        // PageObject ;


        [Given(@"I click 9")]
        public void WhenIClickNine()
        {

            ClickNine();

        }

        [Given(@"I click 8")]
        public void WhenIClickEight()
        {

            ClickEight();

        }

        [When(@"I click add")]
        public void WhenIClickAAdd()
        {

            ClickPlus();

        }

        [When(@"I click equals")]
        public void WhenIClickEquals()
        {

            ClickEquals();

        }


        [When(@"I click 2")]
        public void WhenIClickTwo()
        {

            ClickTwo();

        }

        [When(@"I click subtract")]
        public void WhenIClickMinus()
        {
            ClickMinus();
        }

        [When(@"I click multiply")]
        public void Multiplcation()
        {
            ClickMultiply();
        }

        [When(@"I click divide")]
        public void Division()
        {
            ClickDivide();
        }

        [When(@"I square the selected number")]
        public void Square()
        {
            ScientificCalculator();
            PowerButton();

        }

        [Then(@"I validate the addition answer is correct")]
        public void AdditionAnswer()
        {
            GetCalculatorResultTextAddition();
        }

        [Then(@"I validate the subtraction answer is correct")]
        public void SubtractionAnswer()
        {
            GetCalculatorResultTextSubtraction();
        }

        [Then(@"I validate the multiplication answer is correct")]
        public void MultiplicationAnswer()
        {
            GetCalculatorResultTextMultiplication();
        }

        [Then(@"I validate the division answer is correct")]
        public void DivisionAnswer()
        {
            GetCalculatorResultTextDivision();
        }

        [Then(@"I validate the answer when squaring 9 is correct")]
        public void SquareAnswer()
        {
            GetCalculatorResultTextSquare();
        }
    }
}
