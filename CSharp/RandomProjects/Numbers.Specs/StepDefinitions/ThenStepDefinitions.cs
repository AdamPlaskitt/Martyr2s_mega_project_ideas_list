namespace Numbers.Specs.StepDefinitions
{
    [Binding]
    public sealed class ThenStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public ThenStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Then("the target is (.*)")]
        public void ThenTheTargetIs(int result)
        {
            ((int)_scenarioContext["output"]).Should().Be(result);
        }
    }
}