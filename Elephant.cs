using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    class Elephant : Animal
    {
        public Elephant(string name, int age) : base(name, age) { }

        public override void PerformTrick()
        {
            Console.WriteLine($"{Name} the elephant is balancing on a ball!");
        }
    }

}
