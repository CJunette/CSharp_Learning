using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Declaration1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer custom = new Customer();
            Waiter waiter = new Waiter();
            custom.Order += waiter.Action;
            custom.Action();
        }
    }

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class OrderEventArgs
    {
        public string DishName { get; set; }
        public int Price { get; set; }
    }

    public class Customer
    {
        OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }

        public void WalkIn()
        {
            Console.WriteLine("Walking into the restaurant.");
        }

        public void Thinking()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Thinking...");
                Thread.Sleep(100);
            }

            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Beef";
                e.Price = 50;
                this.orderEventHandler.Invoke(this, e);
            }
        }

        public void Action()
        {
            WalkIn();
            Thinking();
        }
    }

    class Waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you {0}, you need to pay ${1}.", e.DishName, e.Price);
        }
    }


}
