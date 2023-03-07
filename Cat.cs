using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal
    {
        public Cat(string food, string location, string voice) : base(food, location, voice)
        {
            
        }

        public override void makeNoise()
        {
            Console.WriteLine($"Кошка {voice}.");
        }

        public override void eat()
        {
            Console.WriteLine($"Кошка ест  {food}.");
        }

        public override void sleep()
        {
            Console.WriteLine("Кошка спит.\n");
        }
    }
}
