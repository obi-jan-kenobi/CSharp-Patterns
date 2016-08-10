using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    abstract class Duck {
        internal IFlyBehavior flyBehavior;
        internal IQuackBehavior quackBehavior;
        public abstract void display();
        public void performFly() {
            flyBehavior.fly();
        }
        public void performQuak() {
            quackBehavior.quack();
        }
        public void swim() {
            Console.WriteLine("all ducks float");
        }
        public void setFlyBehavior(IFlyBehavior fb) {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb) {
            quackBehavior = qb;
        }
    }
}
