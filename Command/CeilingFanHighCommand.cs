﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class CeilingFanHighCommand : ICommand {
        CeilingFan ceilingFan;
        speeds previousSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan) {
            this.ceilingFan = ceilingFan;
        }

        public void excecute() {
            previousSpeed = ceilingFan.getSpeed();
            ceilingFan.high();
        }

        public void undo() {
            switch (previousSpeed) {
                case speeds.HIGH: { ceilingFan.high(); break; }
                case speeds.MEDIUM: { ceilingFan.medium(); break; }
                case speeds.LOW: { ceilingFan.low(); break; }
                case speeds.OFF: { ceilingFan.off(); break; }
            }
        }
    }
}
