using System;

namespace Command {
    internal class Stereo {

        internal void on() {
            Console.WriteLine("stereo is on");
        }

        internal void setCD() {
            Console.WriteLine("cd is on");
        }

        internal void setVolumen(int v) {
            Console.WriteLine("volume set to " + v);
        }

        internal void off() {
            Console.WriteLine("stereo off");
        }
    }
}