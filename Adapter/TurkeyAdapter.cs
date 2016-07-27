﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class TurkeyAdapter : IDuck {

        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey) {
            this.turkey = turkey;
        }

        public void fly() {
            for(int i = 0; i < 5; i++) {
                turkey.fly();
            }
        }

        public void quack() {
            turkey.gobble();
        }
    }
}
