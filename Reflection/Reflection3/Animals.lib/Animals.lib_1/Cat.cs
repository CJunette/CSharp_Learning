using System;
using System.Collections.Generic;
using System.Text;
//Import the SDK so that we have a rule structure to write .dll files.
using Reflection3_withSDK.SDK;

namespace Animals.lib_1
{
    class Cat : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meow!");
            }
        }
    }
}
