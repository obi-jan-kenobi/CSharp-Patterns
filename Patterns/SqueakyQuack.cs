using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    class SqueakyQuack : IQuackBehavior {
        public void quack() {
            Console.WriteLine("Squeak!");
        }
    }
}
