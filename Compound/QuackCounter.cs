using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class QuackCounter : IQuackable {

        IQuackable Quacker;
        static int NumberOfQuacks;

        public QuackCounter(IQuackable Quacker) {
            this.Quacker = Quacker;
        }

        public void quack() {
            Quacker.quack();
            NumberOfQuacks++;
        }

        public static int GetQuacks() {
            return NumberOfQuacks;
        }

        public void RegisterObserver(IObserver obs) {
            throw new NotImplementedException();
        }

        public void notifyObserver() {
            throw new NotImplementedException();
        }
    }
}
