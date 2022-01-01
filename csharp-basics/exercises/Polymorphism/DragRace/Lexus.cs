using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 10;
        }

        public void SlowDown() 
        {
            if (_currentSpeed > 0)
            {
                _currentSpeed -= 10;
            }
            else
            {
                throw new Exception("You Are Already Stopped");
            }
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            _currentSpeed += 30;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}