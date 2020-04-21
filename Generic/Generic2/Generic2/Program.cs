using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is an example that shows two way to specialize a generic interface.
namespace Generic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> student_1 = new Student<int> { ID = 100 };
            Student<ulong> student_2 = new Student<ulong> { ID = 1000000000000001 };

            Teacher teacher = new Teacher() { ID = 1000000000000001 };
        }
    }

    interface IUnique<Tid>
    {
        Tid ID { get; set; }
    }

    //对泛型接口的第一种特化方式：在创建类时继续使用泛型，在创建实例时特化具体的类型。此时的类仍然是泛型类。
    class Student<Tid> : IUnique<Tid>
    {
        public Tid ID { get; set; }
    }

    //对泛型接口的第二种特化方式：在创建类时就特化具体的类型。此时的类就不在是泛型类了。创建实例时也不需要再对类进行特意地特化。
    class Teacher : IUnique<ulong>
    {
        public ulong ID { get; set; }
    }
}
