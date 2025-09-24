using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class MusaLogarithmicSteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public MusaLogarithmicSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When("I have entered (.*), (.*), and (.*) into the calculator and press logarithmic failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogarithmicFailureIntensity(double lambda0, double muTau, double theta)
        {
            _result = _calculator.LogarithmicFailureIntensity(lambda0, muTau, theta);
        }

        [When("I have entered (.*), (.*), and (.*) into the calculator and press logarithmic expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLogarithmicExpectedFailures(double theta, double lambda0, double tau)
        {
            _result = _calculator.LogarithmicExpectedFailures(theta, lambda0, tau);
        }

        [Then("the logarithmic result should be \"(.*)\"")]
        public void ThenTheLogarithmicResultShouldBe(string expected)
        {
            // Round to 3 decimal places for comparison due to floating point precision
            string actualRounded = Math.Round(_result, 3).ToString();
            Assert.That(actualRounded, Is.EqualTo(expected));
        }
    }
}