using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed += 10;
        }

        public void SlowDown() 
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= 10;
            }
            else
            {
                throw new Exception("You Are Already Stopped");
            }
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}