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
using GameLauncher.Views;

namespace GameLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public Main MainView { get; set; }
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.PlayGame();
        }

        private void PatchNotesButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebsite("https://www.linkedin.com/in/mental-refinery-15732b198/");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
