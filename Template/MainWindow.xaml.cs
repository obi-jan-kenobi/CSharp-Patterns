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

namespace Template {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {

            Duck[] ducks = {
                new Duck("Daffy", 8),
                new Duck("Doofy", 2),
                new Duck("Howard", 3),
                new Duck("Tick", 7),
                new Duck("Trick", 6),
                new Duck("Tack", 7)
            };


            InitializeComponent();
            
            Console.WriteLine("Before sorting:");
            display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("after sorting:");
            display(ducks);
        }

        internal static void display(Duck[] ducks) {
            foreach (Duck duck in ducks) {
                Console.WriteLine(duck);
            }
        }
    }
}
