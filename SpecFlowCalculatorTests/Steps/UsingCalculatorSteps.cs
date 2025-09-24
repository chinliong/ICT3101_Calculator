using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class UsingCalculatorSteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public UsingCalculatorSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given("I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // Calculator is already injected, no need to create new instance
        }

        [When("I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(double first, double second)
        {
            _result = _calculator.Add(first, second);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
    }
}
