using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class AvailabilitySteps
    {
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        private double _result;
        public AvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [When("I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double mttf, double mttr)
        {
            _result = _calculator.MTBF(mttf, mttr);
        }

        [When("I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double mttf, double mttr)
        {
            _result = _calculator.Availability(mttf, mttr);
        }

        [Then("the availability result should be \"(.*)\"")]
        public void ThenTheAvailabilityResultShouldBe(string expected)
        {
            Assert.That(_result.ToString(), Is.EqualTo(expected));
        }
    }
}