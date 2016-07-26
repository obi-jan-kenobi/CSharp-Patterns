using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class SimpleStereoOffCommand : ICommand {
        Stereo stereo;
        public SimpleStereoOffCommand (Stereo stereo) {
            this.stereo = stereo;
        }

        public void excecute() {
            stereo.off();
        }

        public void undo() {
            stereo.on();
        }
    }
}
