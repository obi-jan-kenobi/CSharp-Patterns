using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class RemoteControl {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControl() {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++) {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand) {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonPressed(int slot) {
            onCommands[slot].excecute();
            undoCommand = onCommands[slot];
        }

        public void offButtonPressed(int slot) {
            offCommands[slot].excecute();
            undoCommand = onCommands[slot];
        }

        public void undoButtonPressed() {
            undoCommand.undo();
        }

        public override string ToString() {
            return "";
        }
    }
}
