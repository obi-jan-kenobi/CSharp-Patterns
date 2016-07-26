using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class SimpleStereoOnCommand : ICommand {
        Stereo stereo;

        public SimpleStereoOnCommand(Stereo stereo) {
            this.stereo = stereo;
        }
        public void excecute() {
            stereo.on();
            stereo.setCD();
            stereo.setVolumen(11);
        }
    }
}
