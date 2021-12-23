using System;

namespace MakeSounds
{
    internal class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("shhhhhhh");
        }
    }
}
