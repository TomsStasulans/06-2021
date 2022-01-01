using System;

namespace DragRace
{
    public class Lada : ICar
    {
        private int _currentspeed = 0;
        public string ShowCurrentSpeed()
        {
            return _currentspeed.ToString();
        }

        public void SlowDown()
        {
            if (_currentspeed > 0)
            {
                _currentspeed -= 50;
            }
            else
            {
                throw new Exception("You Are Already Stopped");
            }
        }

        public void SpeedUp()
        {
            _currentspeed += 50;
        }

        public string StartEngine()
        {
            return "--- rum rum rum ---";
        }
    }
}
