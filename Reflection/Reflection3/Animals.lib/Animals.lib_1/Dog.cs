using Reflection3_withSDK.SDK;
using System;

namespace Animals.lib_1
{
    public class Dog : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Woof!");
            }
        }
    }
}
