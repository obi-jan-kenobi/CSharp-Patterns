using System;

namespace Factory {
    internal class PepperoniPizza : Pizza {
        IPizzaIngredientFactory ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare() {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            pepperoni = ingredientFactory.createPepperoni();
            cheese = ingredientFactory.createCheese();
        }
    }
}