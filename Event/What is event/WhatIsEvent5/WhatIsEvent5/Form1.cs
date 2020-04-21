using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsEvent5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //The way we use most to subscribe an event.
            button1.Click += ButtonClicked;

            //Not so popular.
            button2.Click += new EventHandler(this.ButtonClicked);

            //Barely used.
            button3.Click += delegate (object sender, EventArgs e)
            {
                this.textBox1.Text = "hahaha!";
            };

            //This is used to substitute the one above.
            button4.Click += (sender, e) =>
            {
                this.textBox1.Text = "hohoho!";
            };

        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                textBox1.Text = "Hello!";
            }
            if (sender == button2)
            {
                textBox1.Text = "World!";
            }            
        }
    }
}
