namespace Numbers.Specs.StepDefinitions
{
    [Binding]
    public sealed class WhenStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public WhenStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("run")]
        public void WhenRun()
        {
            _scenarioContext.Add("output", Fibonacci.FibonacciElement((int)_scenarioContext["number"]));
        }
    }
}