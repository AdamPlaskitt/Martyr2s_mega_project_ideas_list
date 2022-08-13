using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.Specs.StepDefinitions
{
    [Binding]
    public class ThenStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public ThenStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [When("the response is:")]
        public void GivenThePiDigitsCommandHasNoParameters(string expectedResponse)
        {
            throw new NotImplementedException();
        }
    }
}
