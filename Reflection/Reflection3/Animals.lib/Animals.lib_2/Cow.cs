using Reflection3_withSDK.SDK;
using System;

namespace Animals.lib_2
{
    //Add "Unfinished" attribute to the "Cow".
    [Unfinished]
    public class Cow : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Moo!");
            }
        }
    }
}
