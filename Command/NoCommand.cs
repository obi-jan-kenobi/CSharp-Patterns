using System;

namespace Command {
    internal class NoCommand : ICommand {
        public void excecute() {
            Console.WriteLine("no command assigned");
        }
    }
}