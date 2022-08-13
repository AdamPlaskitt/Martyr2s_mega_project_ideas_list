using NthDigitOfPi.Controller;

namespace NthDigitOfPi.Specs.StepDefinitions
{
    [Binding]
    public sealed class GivenStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public GivenStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the PiDigits command has no parameters")]
        public void GivenThePiDigitsCommandHasNoParameters()
        {
            _scenarioContext.Add("command", new PiDigit());
        }
    }
}