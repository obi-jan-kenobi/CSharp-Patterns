using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class SimpleRemoteControl {
        ICommand slot;
        public SimpleRemoteControl() { }

        public void setCommand(ICommand command) {
            slot = command;
        }

        public void buttonPressed() {
            slot.excecute();
        }
    }
}
