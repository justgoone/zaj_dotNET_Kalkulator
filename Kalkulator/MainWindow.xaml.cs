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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kontroler Kalkulator { get; } = new Kontroler();
        public MainWindow()
        {
            DataContext = Kalkulator;
            InitializeComponent();
        }

        private void Cyfra(object sender, RoutedEventArgs e)
        {
            string cyfra = ((Button)sender).Content.ToString();
            Kalkulator.WprowadźCyfrę(cyfra);
        }
    }
}
