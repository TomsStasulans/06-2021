using System;

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
            if (_currenSpeed > 0)
            {
                _currenSpeed -= 5;
            }
            else
            {
                throw new Exception("You Are Already Stopped");
            }
        }

        public void SpeedUp()
        {
            _currenSpeed += 5;
        }

        public string StartEngine()
        {
            return "--- rum pum pum ---";
        }

        public void UseNitrousOxideEngine()
        {
            _currenSpeed += 100;
        }
    }
}
