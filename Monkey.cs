using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    class Monkey : IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Monkey(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PerformTrick()
        {
            Console.WriteLine($"{Name} the monkey is swinging from a vine!");
        }
    }
}
