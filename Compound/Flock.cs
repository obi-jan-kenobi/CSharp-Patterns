using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class Flock : IQuackable {
        List<IQuackable> Quackers = new List<IQuackable>();
        public void add(IQuackable quacker) {
            Quackers.Add(quacker);
        }

        public void notifyObserver() {
            throw new NotImplementedException();
        }

        public void quack() {
            foreach(IQuackable quacker in Quackers) {
                quacker.quack();
            }
        }

        public void RegisterObserver(IObserver obs) {
            throw new NotImplementedException();
        }
    }
}
