using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Tesla());
            cars.Add(new Volvo());
            cars.Add(new Lexus());
            cars.Add(new Lada());

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if(i == 1)
                    {
                        car.StartEngine();
                        continue;
                    }

                    if(i == 3)
                    {
                        if(car is IBoostable)
                        {
                            ((IBoostable)car).UseNitrousOxideEngine();
                            continue;
                        }
                    }

                    car.SpeedUp();
                }
            }

            var fastest = 0;
            var name = "";
            foreach (var car in cars)
            {
                int carSpeed = int.Parse(car.ShowCurrentSpeed());
                if (carSpeed > fastest)
                {
                    fastest = carSpeed;
                    name = car.GetType().Name;
                }
            }

            Console.WriteLine($"Fastest car is {name} and it's speed is {fastest}");
            Console.ReadKey();
        }
    }
}