using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите код животного, пришедшего на прием: Собака - 1, Кошка - 2, Лошадка - 3");
            int codeanimal = Convert.ToInt32(Console.ReadLine());
            Veterinarian veterinarian = new Veterinarian();

            if (codeanimal == 1)
            {
                Dog dog = new Dog("мясо", "вольер", "лает");
                dog.makeNoise();
                dog.eat();
                dog.sleep();
                veterinarian.treatAnimal(dog);
            }
            
            if (codeanimal == 2)
            {
                Cat cat = new Cat("корм", "мешочек", "мяукает");
                cat.makeNoise();
                cat.eat();
                cat.sleep();
                veterinarian.treatAnimal(cat);
            }

            if (codeanimal == 3)
            {
                Horse horse = new Horse("овес", "конюшня", "ржет");
                horse.makeNoise();
                horse.eat();
                horse.sleep();
                veterinarian.treatAnimal(horse);
            }
            
               
                
            
                
                Console.ReadKey();
            
        }
    }
}
