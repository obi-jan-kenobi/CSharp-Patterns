using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template {
    class Duck : IComparable {
        string name;
        int weight;

        public Duck(string name, int weight) {
            this.name = name;
            this.weight = weight;
        }

        public override string ToString() {
            return name + ": " + weight;
        }

        public int CompareTo(object obj) {
            Duck otherDuck = obj as Duck;
            if (otherDuck == null) {
                return 0;
            }

            if (this.weight < otherDuck.weight) {
                return -1;
            }
            else if (this.weight > otherDuck.weight) {
                return 1;
            }
            else {
                return 0;
            }
        }
    }
}
