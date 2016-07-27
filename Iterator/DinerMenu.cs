using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    class DinerMenu : IMenu {
        const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems { get; set; }

        public DinerMenu() {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("vegetarian blt", "lettuce, tomato and whole wheat", true, 2.99);
            addItem("blt", "bacon, lettuce, tomato and whole wheat", true, 2.99);
            addItem("soup", "soup of the day with a side of potato salad", true, 2.99);
        }

        private void addItem(string name, string description, bool vegetarian, double price) {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if(numberOfItems >= MAX_ITEMS) {
                Console.WriteLine("menu is full");
            } else {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public IMyIterator createIterator() {
            return new DinerMenuIterator(menuItems);
        }
    }
}
