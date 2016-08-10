using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class GumballMachine {
        const int SOLD_OUT = 0;
        const int NO_QUARTER = 1;
        const int HAS_QUARTER = 2;
        const int SOLD = 3;

        int state = SOLD_OUT;
        int count = 0;

        public GumballMachine(int count) {
            this.count = count;
            if(count > 0) {
                state = NO_QUARTER;
            }
        }

        public void insertQuarter() {
            if (state == HAS_QUARTER) {
                Console.WriteLine("You cant insert another quarter");
            } else if (state == NO_QUARTER) {
                state = HAS_QUARTER;
                Console.WriteLine("inserted quarter");
            } else if (state == SOLD_OUT) {
                Console.WriteLine("cant insert. machine is sold out");
            } else if (state == SOLD) {
                Console.WriteLine("already giving you a gumball");
            }
        }

        public void ejectQuarter() {
            if (state == HAS_QUARTER) {
                state = NO_QUARTER;
                Console.WriteLine("ejected your quarter");
            } else if (state== NO_QUARTER) {
                Console.WriteLine("no quarter vorhanden");
            } else if (state == SOLD) {
                Console.WriteLine("already turned the crank");
            } else if (state == SOLD_OUT) {
                Console.WriteLine("cant eject");
            }
        }

        public void turnCrank() {
            if (state == HAS_QUARTER) {
                state = SOLD;
                Console.WriteLine("you turned the crank");
                dispense();
            } else if (state == NO_QUARTER) {
                Console.WriteLine("need to insert quarter first");
            } else if (state == SOLD_OUT) {
                Console.WriteLine("machine is empty");
            } else if (state == SOLD) {
                Console.WriteLine("cant turn the crank twice");
            }
        }

        public void dispense() {
            if (state == SOLD) {
                count--;
                Console.WriteLine("gumball ejected");
                if (count <= 0) {
                    Console.WriteLine("machine sold out");
                } else {
                    state = NO_QUARTER;
                }
            } else if (state == NO_QUARTER) {
                Console.WriteLine("you need to pay first");
            } else if (state == SOLD_OUT) {
                Console.WriteLine("no gumball ejected");
            } else if (state == HAS_QUARTER) {
                Console.WriteLine("no gumball ejected");
            }
        }
    }
}
