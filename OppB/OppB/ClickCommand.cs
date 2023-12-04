namespace OppB
{
    class ClickCommand : ICommand
    {
        private ClickerGame _game;
        public char Character = ' ';

        public ClickCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.Click();
        }
    }
}
