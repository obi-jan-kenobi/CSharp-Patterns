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

namespace Patterns {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Duck mallard;
        Hunter duckHunter;
        public MainWindow() {
            InitializeComponent();
            mallard = new MallardDuck();
            duckHunter = new DuckHunter();
            
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            mallard.performFly();
            mallard.performQuak();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            mallard.setFlyBehavior(new FlyWithRockets());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            duckHunter.performQuack();
            duckHunter.performShoot();
        }
    }
}
