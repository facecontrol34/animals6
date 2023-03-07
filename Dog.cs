using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal
    {
        public Dog(string food, string location, string voice) : base(food, location, voice)
        {

        }

        public override void makeNoise()
        {
            Console.WriteLine($"Собака {voice}.");
        }

        public override void eat()
        {
            Console.WriteLine($"Собака кушает {food}.");

        }

        public override void sleep()
        {
            Console.WriteLine("Собака спит.\n");
        }

        
    }
}

