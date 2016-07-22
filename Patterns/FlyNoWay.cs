using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    class FlyNoWay : FlyBehavior {
       public void fly() {
            Console.WriteLine("i cant fly");
        }
    }
}
