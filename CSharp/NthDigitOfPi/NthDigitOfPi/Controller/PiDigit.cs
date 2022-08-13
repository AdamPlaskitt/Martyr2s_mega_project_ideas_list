using NthDigitOfPi.Interface;
using NthDigitOfPi.Model;

namespace NthDigitOfPi.Controller
{
    public class PiDigit : ICommand
    {
        private readonly IParser command;
        private readonly IModel model;
        private readonly IView view;

        public PiDigit(IParser parser, IModel model, IView view)
        {
            if (parser is null)
            {
                throw new ArgumentNullException(nameof(parser));
            }

            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (view is null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            this.command = parser;
            this.model = model;
            this.view = view;
        }

        public void Execute()
        {
            switch (command.ToAction())
            {
                case CommandActions.Help:
                    view.Render(model.GetHelpMessage());
                    break;

                case CommandActions.Calculate:
                    view.Render(model.Calculate(command.Value));
                    break;

                case CommandActions.Unknown:
                    view.Render(model.GetUnknownCommandMessage());
                    break;
            }
        }
    }
}
