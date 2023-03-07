using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Horse:Animal
    {
        public Horse(string food, string location, string voice) : base(food, location, voice)
        {

        }

        public override void makeNoise()
        {
            Console.WriteLine($"Лошадка {voice}.");
        }

        public override void eat()
        {
            Console.WriteLine($"Лошадка ест {food}.");
        }
        public override void sleep()
        {
            Console.WriteLine("Лошадка спит.\n");
        }
    }
}
