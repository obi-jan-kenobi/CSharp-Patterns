using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    abstract class Hunter {

        internal IQuackBehavior mimicedQuack;
        internal IShootBehavior shootBehavior;

        public void setQuackBehaviour(IQuackBehavior qb) {
            mimicedQuack = qb;
        }

        public void performQuack() {
            mimicedQuack.quack();
        }

        public void performShoot() {
            shootBehavior.shoot();
        }

    }
}
