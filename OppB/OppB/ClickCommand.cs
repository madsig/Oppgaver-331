﻿namespace OppB
{
    class ClickCommand : ICommand
    {
        private readonly ClickerGame _game;
        public char Character { get; } = ' ';

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
