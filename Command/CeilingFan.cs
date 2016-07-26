using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class CeilingFan {
        string location;
        speeds speed;

        public CeilingFan(string location) {
            this.location = location;
            speed = speeds.OFF;
        }

        public void off() {
            speed = speeds.OFF;
            Console.WriteLine(location + " ceilingfan is off");
        }

        public void low() {
            speed = speeds.LOW;
            Console.WriteLine(location + " ceilingfan is at low speed");
        }

        public void medium() {
            speed = speeds.MEDIUM;
            Console.WriteLine(location + " ceilingfan is at medium speed");
        }

        public void high() {
            speed = speeds.HIGH;
            Console.WriteLine(location + " ceilingfan is at high speed");
        }

        public speeds getSpeed() {
            return speed;
        } 
    }

    enum speeds {
        OFF,
        LOW,
        MEDIUM,
        HIGH
    }
}
