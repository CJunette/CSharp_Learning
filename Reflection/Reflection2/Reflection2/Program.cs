using System;
using System.Reflection;
//"Microsoft.Extensions.DependencyInjection" is a NuGet package.
using Microsoft.Extensions.DependencyInjection;

//This case shows the use of dependency injection.
//这里我有点疑惑。刘铁猛老师说依赖注入是基于反射方法的，但从距离来看这些方法都可以直接通过静态类实现，并不需要去调用动态的元数据。
//在程序中，静态与动态在实际应用上究竟有什么区别。
namespace Reflection1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServiceCollection();
            //One of the advantages of "dependency injection" is that we can easily substitute "HeavyTank" to "MediumTank" as the implementation class for "ITank"
            //when we've created a lot of "HeavyTank" in the program. If we use "new" to create instances, we need to change them one by one.
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            var sp = sc.BuildServiceProvider();
            //.................................
            ITank tank = sp.GetService<ITank>();
            tank.Run();
            tank.Fire();

            //This is another example. To create an instance for "Driver", we once need to create the instance for "IVehicle" first.
            //With the help of dependency injection, we just need to do "AddScoped()" and "GetService()".
            sc.AddScoped(typeof(IVehicle), typeof(LightTank));
            sc.AddScoped<Driver>();
            sp = sc.BuildServiceProvider();
            var driver = sp.GetService<Driver>();
            driver.Drive();
        }
    }

    class Driver
    {
        private IVehicle _ivehicle;
        public Driver(IVehicle vehicle)
        {
            _ivehicle = vehicle;
        }

        internal void Drive()
        {
            _ivehicle.Run();
        }
    }

    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

    interface IWeapon
    {
        void Fire();
    }

    interface ITank : IVehicle, IWeapon
    {
    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("boom!");
        }

        public void Run()
        {
            Console.WriteLine("ka ka ka");
        }
    }

    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("ka! ka! ka!");
        }
    }

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka! Ka! Ka!");
        }
    }
}
