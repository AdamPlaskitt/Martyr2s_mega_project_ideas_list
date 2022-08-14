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

        [Given("the target (.*)")]
        public void GivenTheTarget(int number)
        {
            _scenarioContext.Add("number", number);
        }
    }
}