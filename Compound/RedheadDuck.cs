using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class RedheadDuck : IQuackable {

        Observable observable;

        public RedheadDuck() {
            observable = new Observable(this);
        }

        public void notifyObserver() {
            observable.notifyObserver();
        }

        public void quack() {
            Console.WriteLine("Quack");
            notifyObserver();
        }

        public void RegisterObserver(IObserver obs) {
            observable.RegisterObserver(obs);
        }
    }
}
