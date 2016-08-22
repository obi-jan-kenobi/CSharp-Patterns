using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    public class Observable : IQuackObservable {

        List<IObserver> observers = new List<IObserver>();
        IQuackObservable duck;

        public Observable(IQuackObservable duck) {
            this.duck = duck;
        }

        public void notifyObserver() {
            foreach(IObserver observer in observers) {
                observer.update(duck);
            }
        }

        public void RegisterObserver(IObserver obs) {
            observers.Add(obs);
        }
    }
}
