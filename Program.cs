using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMammal> animals = new List<IMammal>();

            Elephant elephant1 = new Elephant("Ellie", 8);
            Lion lion1 = new Lion("Leo", 5);
            Monkey monkey1 = new Monkey("Miko", 3);

            Elephant elephant2 = new Elephant("Ella", 10);
            Lion lion2 = new Lion("Lena", 7);
            Monkey monkey2 = new Monkey("Mia", 4);

            Elephant elephant3 = new Elephant("Edward", 12);
            Lion lion3 = new Lion("Liam", 6);
            Monkey monkey3 = new Monkey("Max", 5);

            animals.Add(elephant1);
            animals.Add(lion1);
            animals.Add(monkey1);
            animals.Add(elephant2);
            animals.Add(lion2);
            animals.Add(monkey2);
            animals.Add(elephant3);
            animals.Add(lion3);
            animals.Add(monkey3);

            foreach (IMammal animal in animals)
            {
                Console.WriteLine($"Introducing {animal.Name}, age {animal.Age}...");
                animal.PerformTrick();
            }

            var onlyIMammals = animals.Where(a => a.GetType().BaseType != typeof(Animal));
            Console.WriteLine("\nAnimals that only implement the IMammal interface:");
            foreach (var animal in onlyIMammals)
            {
                Console.WriteLine(animal.GetType());
            }

            Console.ReadLine();
        }
    }
}
