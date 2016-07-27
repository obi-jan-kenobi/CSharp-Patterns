using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class MallardDuck : IDuck{
        public void quack() {
            Console.WriteLine("Quack");
        }

        public void fly() {
            Console.WriteLine("I'm flying");
        }      
    }
}
