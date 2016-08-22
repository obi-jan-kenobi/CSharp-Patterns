using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State {
    class GumballMachine {

        public IState soldOutState { get; }
        public IState noQuarterState { get; }
        public IState hasQuarterState { get; }
        public IState soldState { get; }
        public IState winnerState { get; }

        public IState state { get; set; }
        
        int count;

        public GumballMachine(int count) {

            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = count;
            if(count > 0) {
                state = noQuarterState;
            } else {
                state = soldOutState;
            }
        }

        public void insertQuarter() {
            state.insertQuarter();
        }

        public void ejectQuarter() {
            state.ejectQuarter();
        }

        public void turnCrank() {
            state.turnCrank();
            state.dispense();
        }

        public void releaseBall() {
            Console.WriteLine("gumball ejecting...");
            if (count > 0) {
                count--;
            }
        }

        public int getCount() {
            return count;
        }
    }
}
