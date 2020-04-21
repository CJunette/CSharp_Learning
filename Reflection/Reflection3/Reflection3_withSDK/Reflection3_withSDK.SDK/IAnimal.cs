using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection3_withSDK.SDK
{
    //Using the interfaec to make sure .dll developer won't forget Voice().
    public interface IAnimal
    {
        void Voice(int times);
    }
}
