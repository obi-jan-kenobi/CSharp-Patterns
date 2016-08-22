using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound {
    public interface IQuackObservable {
        void RegisterObserver(IObserver obs);
        void notifyObserver();
    }
}
