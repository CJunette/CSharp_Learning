using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsEvent3
{
    class Program
    {
        static void Main(string[] args)
        {
            Myform form = new Myform();
            form.Click += form.FormClicked;
            form.ShowDialog();
        }
    }

    class Myform : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
