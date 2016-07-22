using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    class SqueakyQuack : QuackBehavior {
        public void quack() {
            Console.WriteLine("Squeak!");
        }
    }
}
