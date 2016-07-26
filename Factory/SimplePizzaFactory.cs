using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class SimplePizzaFactory {
        public Pizza createPizza(String type) {
            Pizza pizza = null;
            switch (type) {
                case "cheese": pizza = new CheesePizza(); break;
                case "pepperoni": pizza = new PepperoniPizza(); break;
            }
            return pizza;
        }
    }
}
