using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika
{
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog eating");
        }

    }
}
