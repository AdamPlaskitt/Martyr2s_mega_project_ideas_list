namespace Numbers.Specs.StepDefinitions
{
    [Binding]
    public sealed class GivenStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public GivenStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
    }
}