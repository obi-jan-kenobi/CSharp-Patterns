using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command {
    class Light {

        string room;

        public Light(string room) {
            this.room = room;
        }

        internal void on() {
            Console.WriteLine(room + " light on");
        }

        internal void off() {
            Console.WriteLine(room + " light off!");
        }
    }
}
