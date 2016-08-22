using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class RubberDuck : IQuackable {

        Observable observable;

        public void notifyObserver() {
            observable.notifyObserver();
        }

        public void quack() {
            Console.WriteLine("Squeak");
            notifyObserver();
        }

        public void RegisterObserver(IObserver obs) {
            observable.RegisterObserver(obs);
        }
    }
}
