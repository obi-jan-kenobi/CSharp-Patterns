using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class NoQuarterState : IState {

        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gm) {
            gumballMachine = gm;
        }

        public void dispense() {
            Console.WriteLine("no quarter inserted");            
        }

        public void ejectQuarter() {
            Console.WriteLine("no quarter inserted");
        }

        public void insertQuarter() {
            Console.WriteLine("quarter inserted");
            gumballMachine.state = gumballMachine.hasQuarterState;
        }

        public void turnCrank() {
            Console.WriteLine("no quarter inserted");
        }
    }
}
