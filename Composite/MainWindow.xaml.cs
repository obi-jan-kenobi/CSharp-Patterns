using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Composite {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        MenuComponent pancakeHouseMenu;
        MenuComponent dinerMenu;
        MenuComponent cafeMenu;
        MenuComponent dessertMenu;

        MenuComponent allMenus;
        Waitress waitress;
        public MainWindow() {
            InitializeComponent();
            pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            dinerMenu = new Menu("Diner Menu", "Lunch");
            cafeMenu = new Menu("Cafe Menu", "Dinner");
            dessertMenu = new Menu("Dessert Menu", "Dessert of course");
            allMenus = new Menu("ALL MENUS", "All Menus combined");

            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);

            dinerMenu.add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce", true, 3.89));
            dessertMenu.add(new MenuItem("Donut", "Glazed Donut with a Coffee", true, 1.99));
            dinerMenu.add(dessertMenu);

            waitress = new Waitress(allMenus);
            waitress.printMenu();
        }
    }
}
