using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class BasicReliabilitySteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public BasicReliabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When("I have entered (.*), (.*), and (.*) into the calculator and press current failure intensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrentFailureIntensity(double lambda0, double muTau, double nu0)
        {
            _result = _calculator.CurrentFailureIntensity(lambda0, muTau, nu0);
        }

        [When("I have entered (.*), (.*), and (.*) into the calculator and press expected failures")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressExpectedFailures(double nu0, double lambda0, double tau)
        {
            _result = _calculator.AverageExpectedFailures(nu0, lambda0, tau);
        }

        [Then("the reliability result should be \"(.*)\"")]
        public void ThenTheReliabilityResultShouldBe(string expected)
        {
            // Round to 3 decimal places for comparison due to floating point precision
            string actualRounded = Math.Round(_result, 3).ToString();
            Assert.That(actualRounded, Is.EqualTo(expected));
        }
    }
}