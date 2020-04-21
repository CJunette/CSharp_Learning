using System;

namespace MyLib
{
    public class Vehicle
    {
        //“Private”修饰的字段无法被该类以外的成员访问，但是仍然可以通过间接的方式来确定它被继承下来了。
        //这种“_”开头的命名方式是从“C++”和“java”传过来的。其优点在于，可以快速区分一个字段是实例字段且是私有字段。
        private int _fuel;

        //“protected”这种修饰符修饰的字段可以被子类所访问，不能被自身或子类以外的类访问。
        //“protected”这种修饰符可以实现跨程序集（assembly）的访问。
        protected int _rpm;
        
        public void Refuel()
        {
            _fuel = 20;
        }
        public void Accelerate()
        {
            this.Burn(1);
            _rpm += 1000;
        }
        public void ShowFuel()
        {
            Console.WriteLine($"Fuel is {_fuel}.");
        }
        protected void Burn(int fuel)
        {
            _fuel -= fuel;
        }

        public int Speed { get { return _rpm / 100; } }
    }

    public class Car : Vehicle
    {
        public void TurboAccelerate()
        {
            this.Burn(2);
            this._rpm += 3000;
        }
    }
}
