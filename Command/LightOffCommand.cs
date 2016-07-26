using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class LightOffCommand : ICommand {
        Light light;

        public LightOffCommand(Light light) {
            this.light = light;
        }
        public void excecute() {
            light.off();
        }

        public void undo() {
            light.on();
        }
    }
}
