using TechTalk.SpecFlow;
using Xunit;

namespace SampleTestProject.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private int a, b, result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            a = b = result = 0;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            a = number;
            System.Console.WriteLine("First number is: " + a);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            b = number;
            System.Console.WriteLine("Second number is: " + b);
        }

        [When(@"the two numbers are ""(.*)""")]
        public void WhenTheTwoNumbersAre(string operation)
        {
            switch(operation)
            {
                case Calculator.PLUS:
                    result = Calculator.Add(a, b);
                    break;

                case Calculator.MINUS:
                    result = Calculator.Substract(a, b);
                    break;

                case Calculator.MULTIPLY:
                    result = Calculator.Multiply(a, b);
                    break;

                default:
                    System.Console.WriteLine("Unknown Operation: " + operation);
                    break;
            }

            System.Console.WriteLine("Operation: " + operation);
            System.Console.WriteLine("Actual Result: " + result);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            System.Console.WriteLine("Expected Result: "+ result);

            Assert.Equal(result, this.result);
        }
    }
}
