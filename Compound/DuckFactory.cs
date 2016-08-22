using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    class DuckFactory : AbstractDuckFactory {
        public override IQuackable CreateMallardDuck() {
            return new MallardDuck();
        }

        public override IQuackable CreateRedhead() {
            return new RedheadDuck();
        }

        public override IQuackable CreateRubberduck() {
            return new RubberDuck();
        }
    }
}
