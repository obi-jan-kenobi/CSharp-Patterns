using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class PancakeHouseMenu : IMenu {
        List<MenuItem> menuItems { get; set; }
        public PancakeHouseMenu() {
            menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem("pancake breakfast", "pancakes with scrambled eggs", true, 2.99));
            menuItems.Add(new MenuItem("sweet pancake breakfast", "pancakes with blueberries", true, 3.49));
        }

        public IMyIterator createIterator() {
            return new PancakeMenuIterator(menuItems.ToArray());
        }
    }
}
