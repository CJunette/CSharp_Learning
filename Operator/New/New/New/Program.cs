using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oprator "new" could create an instance for a class and triggle the constructor.
            //Oprator "new" could also triggle the initializer[初始化器](those in the "{}", it's used to set the attribute when creating the instance).
            Form myForm = new Form() { Text = "hello" };
            myForm.ShowDialog();

            //Code below could work properly. Because both "new" and "." are operators.
            /*
            new Form().ShowDialog();
            */

            //"new" could also be used to instance an anonymous class.
            var iplic = new { Name = "ABC", age = 10 };
            Console.WriteLine(iplic.Name);
            Console.WriteLine(iplic.age);
            Console.WriteLine(iplic.GetType().Name);

        }
    }
}
