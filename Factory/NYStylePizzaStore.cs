using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class NYStylePizzaStore : PizzaStore {
        
        public override Pizza createPizza(string type) {
            Pizza pizza = null;
            ingredientFactory = new NYPizzaIngredientFactory();
            if(type.Equals("cheese")) {
                pizza = new CheesePizza(ingredientFactory);
            }
            if(type.Equals("pepperoni")) {
                pizza = new PepperoniPizza(ingredientFactory);
            }
            return pizza;
        }
    }
}
