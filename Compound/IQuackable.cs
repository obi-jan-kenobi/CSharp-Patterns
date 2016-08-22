using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    interface IQuackable : IQuackObservable {
        void quack();
    }
}
