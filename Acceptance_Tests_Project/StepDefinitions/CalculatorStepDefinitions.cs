using BPCalculator;

namespace Acceptance_Tests_Project.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        private readonly BloodPressure bloodPressure = new();

        private string? my_result;

        [Given("the Systolic number is (.*)")]
        public void GivenTheSystolicNumberIs(int number)
        {
            bloodPressure.Systolic = number;
        }

        [Given("the Diastolic number is (.*)")]
        public void GivenTheDiastolicNumberIs(int number)
        {
            bloodPressure.Diastolic = number;
        }

        [When("the blood pressure is calculated")]
        public void WhenTheBloodPressureIsCalculated()
        {
            my_result = bloodPressure.Category.ToString();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            my_result.Should().Be(result);
        }
    }
}