using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNamespace;
using MyLib.TestInternal;

namespace ClassModifier1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(1.2, 2.3));
            
            //Class "Student" in "MyNamespace" is internal, that means it could only be accessed by files in the same assambly.(like "ClassModifier1" or "MyLib")
            //The current program is not in the same assembly with "Calculator.cs". That's why I can't access "Student" here.
            //But the "Test" is built in the same assembly(MyLib) with "Student". That's why it can access "Student".
            Test t = new Test();
            t.ShowStudent();
        }
    }
}
