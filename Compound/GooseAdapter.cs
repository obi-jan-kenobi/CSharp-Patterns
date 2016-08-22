using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class GooseAdapter : IQuackable {

        Goose goose;

        public GooseAdapter(Goose goose) {
            this.goose = goose;
        }

        public void notifyObserver() {
            throw new NotImplementedException();
        }

        public void quack() {
            goose.honk();
        }

        public void RegisterObserver(IObserver obs) {
            throw new NotImplementedException();
        }
    }
}
