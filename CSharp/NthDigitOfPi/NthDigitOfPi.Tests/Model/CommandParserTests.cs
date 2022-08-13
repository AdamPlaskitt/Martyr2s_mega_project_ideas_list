using NthDigitOfPi.Interface;
using NthDigitOfPi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.Tests.Model
{
    public class CommandParserTests
    {
        [Fact]
        public void Constructor_with_no_arguments_creates_valid_object()
        {
            var _ = new CommandParser();
        }

        [Fact]
        public void Is_castable_to_Parser()
        {
            Assert.True(typeof(IParser).IsAssignableFrom(typeof(CommandParser)));
        }

        [Fact]
        public void No_using_results_in_help_action()
        {
            IParser parser = new CommandParser();

            var actualAction = parser.ToAction();

            actualAction.Should().Be(CommandActions.Help);
        }

        [Fact]
        public void Using_null_results_in_help_action()
        {
            IParser parser = new CommandParser();

            var actualAction = parser.Using(null).ToAction();

            actualAction.Should().Be(CommandActions.Help);
        }

        [Fact]
        public void Using_empty_collection_results_in_help_action()
        {
            IParser parser = new CommandParser();

            string[] args = Array.Empty<string>();

            var actualAction = parser.Using(args).ToAction();

            actualAction.Should().Be(CommandActions.Help);
        }

        [Fact]
        public void Using_h_results_in_help_action()
        {
            IParser parser = new CommandParser();

            string[] args = { "-h" };

            var actualAction = parser.Using(args).ToAction();

            actualAction.Should().Be(CommandActions.Help);
        }

        [Fact]
        public void Using_help_results_in_help_action()
        {
            IParser parser = new CommandParser();

            string[] args = { "--help" };

            var actualAction = parser.Using(args).ToAction();

            actualAction.Should().Be(CommandActions.Help);
        }

        [Theory]
        [InlineData("unknown")]
        [InlineData("random")]
        public void Using_unknown_command_results_in_unknown_action(string arg)
        {
            IParser parser = new CommandParser();

            string[] args = { arg };

            var actualAction = parser.Using(args).ToAction();

            actualAction.Should().Be(CommandActions.Unknown);
        }

        [Theory]
        [InlineData("unknown", "test")]
        [InlineData("random", "example")]
        public void Using_unknown_2_part_command_results_in_unknown_action(string arg1, string arg2)
        {
            IParser parser = new CommandParser();

            string[] args = { arg1, arg2 };

            var actualAction = parser.Using(args).ToAction();

            actualAction.Should().Be(CommandActions.Unknown);
        }

        [Theory]
        [InlineData("-1")]
        [InlineData("-42")]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("42")]
        [InlineData("0.42")]
        [InlineData("42.42")]
        public void Using_number_results_in_calculate_action(string arg)
        {
            IParser parser = new CommandParser();

            string[] args = { arg };

            var actualAction = parser.Using(args).ToAction();

            actualAction.Should().Be(CommandActions.Calculate);
        }
    }
}
