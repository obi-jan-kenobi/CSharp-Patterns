using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    abstract class Pizza {
        string name;
        internal Dough dough;
        internal Sauce sauce;
        internal Veggies[] veggies;
        internal Cheese cheese;
        internal Pepperoni pepperoni;
        internal Clams clam;

        public abstract void prepare();

        public void setName(string name) { this.name = name; }
        public string getName() { return name; }

        public void bake() { }
        public void cut() { }
        public void box() { }
    }
}
