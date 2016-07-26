using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class NYPizzaIngredientFactory : IPizzaIngredientFactory {
        public Cheese createCheese() {
            return new CheeseGouda();
        }

        public Clams createClam() {
            return new ClamHamaguri();
        }

        public Dough createDough() {
            return new DoughRicedough();
        }

        public Pepperoni createPepperoni() {
            return new PepperoniHabanero();
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
