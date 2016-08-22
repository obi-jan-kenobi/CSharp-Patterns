using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class SoldState : IState {

        GumballMachine gumballMachine;

        public SoldState(GumballMachine gm) {
            gumballMachine = gm;
        }

        public void dispense() {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() > 0) {
                gumballMachine.state = gumballMachine.noQuarterState;
            } else {
                Console.WriteLine("out of gumballs");
                gumballMachine.state = gumballMachine.soldOutState;
            }            
        }

        public void ejectQuarter() {
            throw new NotImplementedException();
        }

        public void insertQuarter() {
            throw new NotImplementedException();
        }

        public void turnCrank() {
            throw new NotImplementedException();
        }
    }
}
