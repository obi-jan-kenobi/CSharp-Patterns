using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    abstract class MenuComponent {
        public virtual void add(MenuComponent mc) {
            throw new NotImplementedException();
        }

        public virtual void remove(MenuComponent mc) {
            throw new NotImplementedException();
        }

        public virtual MenuComponent getChild(int i) {
            throw new NotImplementedException();
        }

        public virtual string getName() {
            throw new NotImplementedException();
        }

        public virtual string getDescription() {
            throw new NotImplementedException();
        }

        public virtual double getPrice() {
            throw new NotImplementedException();
        }

        public virtual bool isVegetarian() {
            throw new NotImplementedException();
        }

        public virtual void print() {
            throw new NotImplementedException();
        }
    }
}
