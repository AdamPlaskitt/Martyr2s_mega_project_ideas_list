using Fibonacci_Sequence;

namespace FibonacciSequence.Specs.StepDefinitions
{
    [Binding]
    public sealed class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the target (.*)")]
        public void GivenTheTarget(int number)
        {
            _scenarioContext.Add("number", number);
        }

        [When("run")]
        public void WhenRun()
        {
            _scenarioContext.Add("output", Program.FibonacciElement((int)_scenarioContext["number"]));
        }

        [Then("the target is (.*)")]
        public void ThenTheTargetIs(int result)
        {
            ((int)_scenarioContext["output"]).Should().Be(result);
        }
    }
}