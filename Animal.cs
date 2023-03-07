using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string food;
        public string location;
        public string voice;

        public Animal(string food, string location, string voice)
        {
            this.food = food;
            this.location = location;
            this.voice = voice;
        }
        public virtual void makeNoise()
        {
            Console.WriteLine("Животное шумит.");
        }

        public virtual void eat()
        {
            Console.WriteLine("Животное ест.");
        }

        public virtual void sleep()
        {
            Console.WriteLine("Животное спит.");
        }
    }
}
