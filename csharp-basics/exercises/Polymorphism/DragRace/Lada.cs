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
            _currentspeed -= 50;
        }

        public void SpeedUp()
        {
            _currentspeed += 50;
        }

        public void StartEngine()
        {
            System.Console.WriteLine("--- rum rum rum ---");
        }
    }
}
