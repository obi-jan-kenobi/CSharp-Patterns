using System.Windows;

namespace Observer {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Weatherdata weatherData;
        public MainWindow() {
            InitializeComponent();
            weatherData = new Weatherdata();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.setMeasurements(80, 64, 30.4f);
        }
    }
}
