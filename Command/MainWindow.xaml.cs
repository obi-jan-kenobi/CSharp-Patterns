﻿using System;
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

namespace Command {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            RemoteControl remote = new RemoteControl();
            Light livingroomLight = new Light("living room");
            Light kitchenLight = new Light("kitchen");
            Stereo stereo = new Stereo();
            remote.setCommand(0, new LightOnCommand(livingroomLight), new LightOffCommand(livingroomLight));
            remote.setCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remote.setCommand(2, new SimpleStereoOnCommand(stereo), new SimpleStereoOffCommand(stereo));

            remote.onButtonPressed(0);
            remote.onButtonPressed(1);
            remote.onButtonPressed(2);

            remote.offButtonPressed(0);
            remote.offButtonPressed(1);
            remote.offButtonPressed(2);
        }
    }
}
