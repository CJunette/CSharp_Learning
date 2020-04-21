using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
        }
    }

    public delegate void OrderEventHandler(Customer custom, OrderEventArgs e);

    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public class Customer
    {
        OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order
        {
            add
            {
                orderEventHandler += value;
            }
            remove
            {
                orderEventHandler -= value;
            }
        }

        public void WalkIn()
        {
            Console.WriteLine("Walking in...");
        }

        public void Thinking()
        {
            Console.WriteLine("Thinking...");
        }

        public void MakeOrder()
        {
            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Beef";
                e.Size = DiseSize.Large.ToString();
                Console.WriteLine("\"I would like to eat {0} in {1} size.\"", e.DishName, e.Size);
                Console.WriteLine("......");
                orderEventHandler.Invoke(this, e);
            }
        }

        public void Action()
        {
            this.WalkIn();
            this.Thinking();
            this.MakeOrder();
        }
    }

    public class Waiter
    {
        public void Action(Customer custom, OrderEventArgs e)
        {
            double price = 40;
            switch (e.Size)
            {
                case "Large":
                    price *= 1.5;
                    break;
                case "Medium":
                    price *= 1;
                    break;
                case "Small":
                    price *= 0.75;
                    break;
                default:
                    break;
            }
            Console.WriteLine("\"Hello.\"");
            Console.WriteLine("\"I will serve you {0}.\"", e.DishName);
            Console.WriteLine("\"You need to pay {0}.\"", price);
        }
    }

    public enum DiseSize
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }
}
