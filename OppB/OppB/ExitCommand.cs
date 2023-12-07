namespace OppB
{
    internal class ExitCommand : ICommand
    {
        private readonly ClickerGame _game;
        public char Character { get; } = 'X';

        public ExitCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Exit();
        }
    }
}
