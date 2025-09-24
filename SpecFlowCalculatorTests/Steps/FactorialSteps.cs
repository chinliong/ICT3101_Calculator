using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class FactorialSteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public FactorialSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When("I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double number)
        {
            _result = _calculator.Factorial(number);
        }

        [Then("the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
    }
}