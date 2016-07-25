﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator {
    class Mocha : CondimentDecorator {
        Beverage beverage;

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override double cost() {
            return beverage.cost() + 0.20;
        }

        public override string getDescription() {
            return beverage.getDescription() + ", Mocha";
        }
    }
}
