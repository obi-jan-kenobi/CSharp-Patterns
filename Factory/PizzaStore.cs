using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    abstract class PizzaStore {
        internal IPizzaIngredientFactory ingredientFactory;

        public Pizza orderPizza(string item) {
            Pizza pizza;
            pizza = createPizza(item);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }

        public abstract Pizza createPizza(string item);
    }
}
