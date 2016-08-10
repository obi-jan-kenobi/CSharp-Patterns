using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    class ShootWithShotgun : IShootBehavior {
        public void shoot() {
            Console.WriteLine("KABOOM!");
        }
    }
}
