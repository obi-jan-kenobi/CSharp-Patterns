using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class DinerMenuIterator : IMyIterator {

        MenuItem[] items;
        int position;

        public DinerMenuIterator(MenuItem[] items) {
            this.items = items;
        }

        public bool hasNext() {
            if (position + 1 > items.Length || items[position] == null)
                return false;
            return true;
        }

        public object next() {
            MenuItem item = items[position];
            position++;
            return item;
        }
    }
}
