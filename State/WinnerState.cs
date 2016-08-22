using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class WinnerState : IState {

        GumballMachine gumballMachine;

        public WinnerState (GumballMachine gm) {
            gumballMachine = gm;
        }

        public void dispense() {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() <= 0) {
                gumballMachine.state = gumballMachine.soldOutState;
            } else {
                Console.WriteLine("youre a winner");
                gumballMachine.releaseBall();
                if(gumballMachine.getCount() <= 0) {
                    gumballMachine.state = gumballMachine.soldOutState;
                } else {
                    gumballMachine.state = gumballMachine.noQuarterState;
                }
            }
        }

        public void ejectQuarter() {
            Console.WriteLine("cant eject quarter");
        }

        public void insertQuarter() {
            Console.WriteLine("cant insert another quarter");
        }

        public void turnCrank() {
            Console.WriteLine("cant turn crank again");
        }
    }
}
