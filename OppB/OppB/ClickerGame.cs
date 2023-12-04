namespace OppB
{
    internal class ClickerGame
    {
        private int _points;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;

        public void Click()
        {
            _points++;
        }

        public void Upgrade()
        {
            if (_points >= 10)
            {
                _pointsPerClick++;
            }
        }

        public void SuperUpgrade()
        {
            if (_points >= 100)
            {
                _pointsPerClickIncrease++;
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
