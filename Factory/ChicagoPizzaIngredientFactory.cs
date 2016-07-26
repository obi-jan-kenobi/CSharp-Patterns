using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory {
        public Cheese createCheese() {
            return new CheeseParmesan();
        }

        public Clams createClam() {
            return new ClamHamaguri();
        }

        public Dough createDough() {
            return new DoughSourdough();
        }

        public Pepperoni createPepperoni() {
            return new PepperoniJalapeno();
        }

        public Sauce createSauce() {
            return new SauceMarina();
        }

        public Veggies[] createVeggies() {
            Veggies[] veggies = { new VeggiesPaprika(), new VeggiesTomato() };
            return veggies;
        }
    }
}
