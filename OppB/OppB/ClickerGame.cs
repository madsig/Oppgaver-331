namespace OppB
{
    internal class ClickerGame
    {
        public int Points { get; private set; }
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;

        public void Click()
        {
            Points += _pointsPerClick;
        }

        public void Upgrade()
        {
            if (Points >= 10)
            {
                _pointsPerClick++;
                Points -= 10;
            }
        }

        public void SuperUpgrade()
        {
            if (Points >= 100)
            {
                _pointsPerClickIncrease++;
                Points -= 100;
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
