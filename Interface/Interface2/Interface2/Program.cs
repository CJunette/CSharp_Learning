using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneUser Steve = new PhoneUser(new NokiaPhone());
            Steve.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Recieve();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Recieve();
    }

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Steve!");
        }

        public void Recieve()
        {
            Console.WriteLine("Nokia message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Steve!");
        }

        public void Recieve()
        {
            Console.WriteLine("Ericsson message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }
}
