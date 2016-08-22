using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class SoldOutState : IState {

        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gm) {
            gumballMachine = gm;
        }

        public void dispense() {
            Console.WriteLine("no gumballs");
        }

        public void ejectQuarter() {
            Console.WriteLine("no gumballs");
        }

        public void insertQuarter() {
            Console.WriteLine("no gumballs");
        }

        public void turnCrank() {
            Console.WriteLine("no gumballs");
        }
    }
}
