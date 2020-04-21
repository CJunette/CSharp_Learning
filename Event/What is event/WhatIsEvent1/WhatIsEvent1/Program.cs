using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WhatIsEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 500;
            Boy boy = new Boy();
            Girl girl = new Girl();
            timer.Elapsed += boy.action;
            timer.Elapsed += girl.action;
            timer.Start();
            Console.ReadLine();

        }
    }

    class Boy
    {
        internal void action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {
        internal void action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
