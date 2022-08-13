using NthDigitOfPi.Interface;

namespace NthDigitOfPi.Specs.StepDefinitions
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
            if (_scenarioContext.ContainsKey("command"))
            {
                ((ICommand)_scenarioContext["command"]).Execute();
            } else
            {
                throw new Exception("No command configured.");
            }
        }
    }
}