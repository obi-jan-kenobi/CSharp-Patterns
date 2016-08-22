using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class CountingDuckFactory : AbstractDuckFactory {
        public override IQuackable CreateMallardDuck() {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRedhead() {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateRubberduck() {
            return new QuackCounter(new RubberDuck());
        }
    }
}
