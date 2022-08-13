using NthDigitOfPi.Interface;
using NthDigitOfPi.Specs.Util;
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


        [Then("the response is:")]
        public void ThenTheResponseIsBlock(string expectedResponse)
        {
            Mock<IView> view = (Mock<IView>)_scenarioContext["view"];

            var actualResponse = new ArgumentCaptor<string>();
            view.Verify(x => x.Render(actualResponse.Capture()));

            actualResponse.Value.Should().Be(expectedResponse);
        }


        [Then("the response is (.*)")]
        public void ThenTheResponseIs(string expectedResponse)
        {
            Mock<IView> view = (Mock<IView>)_scenarioContext["view"];

            var actualResponse = new ArgumentCaptor<string>();
            view.Verify(x => x.Render(actualResponse.Capture()));

            actualResponse.Value.Should().Be(expectedResponse);
        }
    }
}
