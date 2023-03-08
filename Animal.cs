using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    abstract class Animal : IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void PerformTrick();

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {GetType().Name}, name is {Name}, age is {Age}.");
        }
    }
}
