using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    abstract class Hunter {

        internal QuackBehavior mimicedQuack;
        internal ShootBehavior shootBehavior;

        public void setQuackBehaviour(QuackBehavior qb) {
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
