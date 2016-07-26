using System;

namespace Factory {
    internal class CheesePizza : Pizza {
        IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare() {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}