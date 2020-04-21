using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This case shows how to use explicit implement to hide the method.
namespace InterfaceSegregation3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit implement ensures that a method can't be accessed if the variable is of a different type.
            WarmKiller wk_1 = new WarmKiller();
            wk_1.Love();            

            //Only by using the variable of same type, the hidden method will show up.
            IKiller wk_2 = new WarmKiller();
            wk_2.Kill();

            //But now we lost the ability to access the "love()" method.
            //The only way to get it back is to create a new variable.
            var wk_3 = wk_2 as WarmKiller;
            //Same way.
            wk_3 = (WarmKiller)wk_2;            
            wk_3.Love();

            //Codes below could work because the instance "wk_2" is pointing at is a "WarmKiller".
            //Though "wk_2" is an "IKiller" variable, the cast could still happen for a "WarmKiller" instance.
            var wk_4 = (IGentleman)wk_2;
            wk_4.Love();

            //Another way to use both Love() and Kill() is as below.
            WarmKiller wk_5 = new WarmKiller();
            (wk_5 as IKiller).Kill();
            (wk_5 as IGentleman).Love();
        }
    }

    interface IGentleman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    public class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("This is a beautiful world!");
        }

        //Use the explicit way to hide the method.
        void IKiller.Kill()
        {
            Console.WriteLine("You don't belong to this beautiful world...");
        }
    }
}
