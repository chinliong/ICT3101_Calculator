using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class DivisionSteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public DivisionSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When("I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double numerator, double denominator)
        {
            _result = _calculator.Divide(numerator, denominator);
        }

        [Then("the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [Then("the division result equals (.*)")]
        public void ThenTheDivisionResultEquals(string token)
        {
            if (token.Equals("positive_infinity", System.StringComparison.OrdinalIgnoreCase))
            {
                Assert.That(double.IsPositiveInfinity(_result), "Expected +∞");
            }
            else if (token.Equals("negative_infinity", System.StringComparison.OrdinalIgnoreCase))
            {
                Assert.That(double.IsNegativeInfinity(_result), "Expected -∞");
            }
            else
            {
                Assert.Fail($"Unknown expected token: {token}");
            }
        }
    }
}
