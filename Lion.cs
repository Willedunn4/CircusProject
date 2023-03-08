using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age) { }

        public override void PerformTrick()
        {
            Console.WriteLine($"{Name} the lion is jumping through a ring of fire!");
        }
    }
}
