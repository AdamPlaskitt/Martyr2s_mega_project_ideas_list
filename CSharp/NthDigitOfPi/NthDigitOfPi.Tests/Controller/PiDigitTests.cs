using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NthDigitOfPi.Controller;
using NthDigitOfPi.Interface;
using NthDigitOfPi.Model;

namespace NthDigitOfPi.Tests.Controller
{
    public class PiDigitTests
    {
        [Fact]
        public void PiDigit_is_castable_to_Command()
        {
            Assert.True(typeof(ICommand).IsAssignableFrom(typeof(PiDigit)));
        }

        [Fact]
        public void PiDigit_constructs_with_parsers()
        {
            var parser = new Mock<IParser>();
            var view = new Mock<IView>();
            var model = new Mock<IModel>();
            var _ = new PiDigit(parser.Object, model.Object, view.Object);
        }

        [Fact]
        public void PiDigit_with_null_parser_returns_ArgumentException()
        {
            var view = new Mock<IView>();
            var model = new Mock<IModel>();
            Action constructor = () => _ = new PiDigit(null, model.Object, view.Object);

            constructor.Should().ThrowExactly<ArgumentNullException>().WithMessage("Value cannot be null. (Parameter 'parser')");
        }

        [Fact]
        public void PiDigit_with_null_model_returns_ArgumentException()
        {
            var parser = new Mock<IParser>();
            var view = new Mock<IView>();
            Action constructor = () => _ = new PiDigit(parser.Object, null, view.Object);

            constructor.Should().ThrowExactly<ArgumentNullException>().WithMessage("Value cannot be null. (Parameter 'model')");
        }

        [Fact]
        public void PiDigit_with_null_view_returns_ArgumentException()
        {
            var parser = new Mock<IParser>();
            var model = new Mock<IModel>();
            Action constructor = () => _ = new PiDigit(parser.Object, model.Object, null);

            constructor.Should().ThrowExactly<ArgumentNullException>().WithMessage("Value cannot be null. (Parameter 'view')");
        }

        [Fact]
        public void Parsed_help_action_calls_model_help()
        {
            var parser = new Mock<IParser>();
            parser.Setup(x => x.ToAction()).Returns(CommandActions.Help);

            var model = new Mock<IModel>();
            model.Setup(x => x.GetHelp()).Returns("help");

            var view = new Mock<IView>();

            ICommand command = new PiDigit(parser.Object, model.Object, view.Object);
            command.Execute();

            view.Verify(x => x.Render("help"));
        }
    }
}
