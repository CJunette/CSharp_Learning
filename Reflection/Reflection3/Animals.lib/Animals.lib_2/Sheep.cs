using Reflection3_withSDK.SDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.lib_2
{
    class Sheep : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Mee!");
            }
        }
    }
}
