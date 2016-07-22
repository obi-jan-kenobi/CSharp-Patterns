using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    abstract class Duck {
        internal FlyBehavior flyBehavior;
        internal QuackBehavior quackBehavior;
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
        public void setFlyBehavior(FlyBehavior fb) {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb) {
            quackBehavior = qb;
        }
    }
}
