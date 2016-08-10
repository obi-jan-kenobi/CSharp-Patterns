using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    class Menu : MenuComponent {
        List<MenuComponent> menuComponents;
        string name;
        string description;

        public Menu(string name, string description) {
            this.name = name;
            this.description = description;
            menuComponents = new List<MenuComponent>();
        }

        public override void add(MenuComponent mc) {
            menuComponents.Add(mc);
        }

        public override void remove(MenuComponent mc) {
            menuComponents.Remove(mc);
        }

        public override MenuComponent getChild(int i) {
            return menuComponents.ElementAt(i);
        }

        public override string getName() {
            return name;
        }

        public override string getDescription() {
            return description;
        }

        public override void print() {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("----------------");

            foreach (MenuComponent menuComp in menuComponents) {
                menuComp.print();
            }            
        }        
    }
}
