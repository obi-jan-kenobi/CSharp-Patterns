using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    abstract class AbstractDuckFactory {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRedhead();
        public abstract IQuackable CreateRubberduck();
    }
}
