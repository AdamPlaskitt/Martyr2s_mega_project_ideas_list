using NthDigitOfPi.Controller;
using NthDigitOfPi.Interface;
using NthDigitOfPi.Model;
using NthDigitOfPi.View;

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
            IParser parser = new CommandParser();
            IModel model = new Calculator();
            Mock<IView> view = new Mock<IView>();

            _scenarioContext.Add("command", new PiDigit(parser, model, view.Object));
            _scenarioContext.Add("view", view);
        }
    }
}