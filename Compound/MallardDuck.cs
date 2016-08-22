using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class MallardDuck : IQuackable {
        Observable observable;

        public MallardDuck() {
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
