using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Veterinarian
    {
        public void treatAnimal(Animal animal)
        {
            Console.WriteLine("Животное: " + animal);
            Console.WriteLine("Звук: " + animal.voice);
            Console.WriteLine("Еда: " + animal.food);
            Console.WriteLine("Местоположение: " + animal.location + "\n");
        }
    }
}
