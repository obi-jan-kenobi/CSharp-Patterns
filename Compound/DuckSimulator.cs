using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class DuckSimulator {

        public void simulate(AbstractDuckFactory duckFactory) {
            Flock flockOfMallards = new Flock();
            flockOfMallards.add(duckFactory.CreateMallardDuck());
            flockOfMallards.add(duckFactory.CreateMallardDuck());
            flockOfMallards.add(duckFactory.CreateMallardDuck());
            flockOfMallards.add(duckFactory.CreateMallardDuck());
            flockOfMallards.add(duckFactory.CreateMallardDuck());
            simulate(flockOfMallards);
        }

        public void simulate(IQuackable duck) {
            duck.quack();
        }
    }
}
