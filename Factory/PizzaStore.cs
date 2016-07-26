using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    abstract class PizzaStore {
        SimplePizzaFactory factory;
        public PizzaStore (SimplePizzaFactory factory) {
            this.factory = factory;
        }

        public Pizza orderPizza(String type) {
            Pizza pizza;

            pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(String type);
    }
}
