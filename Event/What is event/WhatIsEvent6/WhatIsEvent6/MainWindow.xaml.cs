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

namespace WhatIsEvent6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //"button1.Click" is defined in XMAL.
            button2.Click += new RoutedEventHandler(ButtonClick);
            button3.Click += ButtonClick;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender == button1)
            {
                this.textBox1.Text = "Hello World!";
            }

            if (sender == button2)
            {
                this.textBox1.Text = "Hello Human!";
            }

            if (sender == button3)
            {
                this.textBox1.Text = "Hello You!";
            }
        }
    }
}
