using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class HasQuarterState : IState {
        Random rng;
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gm) {
            rng = new Random();
            gumballMachine = gm;
        }

        public void dispense() {
            Console.WriteLine("no gumball dispensed");
        }

        public void ejectQuarter() {
            Console.WriteLine("quarter returned");
            gumballMachine.state = gumballMachine.noQuarterState;
        }

        public void insertQuarter() {
            Console.WriteLine("cant insert another quarter");
        }

        public void turnCrank() {
            int winner = rng.Next(10);
            Console.WriteLine("you turned...");
            if (winner == 0 && gumballMachine.getCount() > 1) {
                gumballMachine.state = gumballMachine.winnerState;
            } else             
                gumballMachine.state = gumballMachine.soldState;
        }
    }
}
