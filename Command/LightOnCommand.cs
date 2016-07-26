using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class LightOnCommand : ICommand {

        internal Light light;

        public LightOnCommand(Light light) {
            this.light = light;
        }

        public void excecute() {
            light.on();
        }
    }
}
