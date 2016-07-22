using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns {
    class DuckHunter : Hunter {
        public DuckHunter() {
            mimicedQuack = new MimicedQuack();
            shootBehavior = new ShootWithShotgun();
        }
    }
}
