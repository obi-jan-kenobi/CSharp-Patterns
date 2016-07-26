using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class ChicagoStylePizzaStore : PizzaStore {
        public ChicagoStylePizzaStore(SimplePizzaFactory factory) : base(factory) {
        }

        public override Pizza createPizza(string type) {
            Pizza pizza = null;
            switch (type) {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
            }
            return pizza;
        }
    }
}
