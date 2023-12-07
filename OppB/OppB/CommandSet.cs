namespace OppB
{
    internal class CommandSet
    {
        private ICommand[] _commands;

        public CommandSet(ClickerGame game)
        {
            _commands = new ICommand[]
            {
                new ClickCommand(game),
                new UpgradeCommand(game),
                new SuperUpgradeCommand(game),
                new ExitCommand(game)
            };
        }

        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            command?.Run();
        }

        private ICommand? FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
