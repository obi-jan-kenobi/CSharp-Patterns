using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    class Decaf : Beverage {

        public Decaf() {
            description = "Not Caffein";
        }

        public override double cost() {
            return 1.29;
        }
    }
}
