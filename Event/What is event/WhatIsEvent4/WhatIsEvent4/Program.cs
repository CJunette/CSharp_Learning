using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsEvent4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.ShowDialog();
        }
    }

    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;
        public MyForm()
        {
            textBox = new TextBox();
            button = new Button();
            this.Controls.Add(textBox);
            this.Controls.Add(button);
            this.button.Click += this.ButtonClicked;
            this.button.Text = "Say Hello world!";
            this.button.Top = 50;
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello World!";
        }
    }
}
