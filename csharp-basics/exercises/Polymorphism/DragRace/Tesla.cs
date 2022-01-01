using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 15;
        }

        public void SlowDown() 
        {
            if (_currentSpeed > 0)
            {
                _currentSpeed -= 15;
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

        public string StartEngine() 
        {
            return "-- silence ---";
        }
    }
}