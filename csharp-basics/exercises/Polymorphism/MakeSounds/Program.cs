using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound>();
            sounds.Add(new Firework());
            sounds.Add(new Firework());
            sounds.Add(new Parrot());
            sounds.Add(new Parrot());
            sounds.Add(new Radio());
            sounds.Add(new Radio());

            foreach (var sound in sounds)
            {
                sound.PlaySound();
            }

            Console.ReadKey();
        }
    }
}