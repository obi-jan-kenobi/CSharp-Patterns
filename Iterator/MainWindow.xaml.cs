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

namespace Iterator {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        IMenu pancake;
        IMenu diner;
        public MainWindow() {
            pancake =  new PancakeHouseMenu();
            diner = new DinerMenu();

            IMyIterator pIt = pancake.createIterator();
            IMyIterator dIt = diner.createIterator();
            

            while (pIt.hasNext()) {
                Console.WriteLine(pIt.next());
            }

            while(dIt.hasNext()) {
                Console.WriteLine(dIt.next());
            }
            InitializeComponent();
        }
    }
}
