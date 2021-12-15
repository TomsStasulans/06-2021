namespace DragRace
{
    public class Volvo : ICar, IBoostable
    {
        private int _currenSpeed = 0;
        public string ShowCurrentSpeed()
        {
            return _currenSpeed.ToString();
        }

        public void SlowDown()
        {
            _currenSpeed -= 5;
        }

        public void SpeedUp()
        {
            _currenSpeed += 5;
        }

        public void StartEngine()
        {
            System.Console.WriteLine("--- rum pum pum ---");
        }

        public void UseNitrousOxideEngine()
        {
            _currenSpeed += 100;
        }
    }
}
