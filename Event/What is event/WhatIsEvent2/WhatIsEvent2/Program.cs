using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatIsEvent2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "hello world";
            Controller ctrl = new Controller(form);
            form.ShowDialog();
        }
    }

    class Controller
    {        
        private Form form = new Form();

        public Controller(Form form)
        {
            if (form != null)
            {                
                Console.WriteLine(form.GetHashCode());
                this.form = form;
                Console.WriteLine(form.GetHashCode());
                this.form.Click += this.FormClick;
            }
        }

        public void Show()
        {
            Console.WriteLine(this.form.Text);
        }

        private void FormClick(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
