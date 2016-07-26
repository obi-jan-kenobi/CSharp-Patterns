using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class Pizza {
        string name;
        string dough;
        string sauce;
        List<string> toppings = new List<string>();
        public void prepare() { }
        public void bake() { }
        public void cut() { }
        public void box() { }
    }
}
