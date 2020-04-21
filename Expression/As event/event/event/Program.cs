using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @event
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form();
            myForm.Text = "Hello";
            myForm.Load += MyForm_Load;
            myForm.ShowDialog();
        }

        private static void MyForm_Load(object sender, EventArgs e)
        {
            Form form = sender as Form;

            if (form == null)
            {
                return ;
            }

            form.Text = "New form";
        }
    }
}
