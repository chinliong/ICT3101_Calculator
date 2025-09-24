using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class QualityMetricsSteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public QualityMetricsSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When("I have entered (.*) and (.*) into the calculator and press defect density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(double defects, double kloc)
        {
            _result = _calculator.DefectDensity(defects, kloc);
        }

        [When("I have entered (.*), (.*), and (.*) into the calculator and press new SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressNewSSI(double totalSSI, double previousSSI, double deletedSSI)
        {
            _result = _calculator.NewSSI(totalSSI, previousSSI, deletedSSI);
        }

        [Then("the quality metrics result should be \"(.*)\"")]
        public void ThenTheQualityMetricsResultShouldBe(string expected)
        {
            // Round to 3 decimal places for comparison due to floating point precision
            string actualRounded = Math.Round(_result, 3).ToString();
            Assert.That(actualRounded, Is.EqualTo(expected));
        }
    }
}