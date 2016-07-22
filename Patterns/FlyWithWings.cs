using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    class FlyWithWings : FlyBehavior {
        public void fly() {
            Console.WriteLine("up up and away");
        }
    }
}
