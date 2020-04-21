using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//This program shows how to use the defalut "EventHandler" to create an event.
//We can save the work of creating a new custom delegate class.
namespace Declaration2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Hello;
            customer.Order += waiter.Action;

            customer.MakeOrder();

            customer.PayTheBill();
        }
    }

    //We won't need "OrderEventHandler" if we are using the default "EventHandler".
    /*
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    */

    //Because "EventHandler" requires "EventArgs" as input parameter, all the customized event args must use
    //"EventArgs" as their base class.
    public class OrderEventArgs : EventArgs
    {
        public string Dishname { get; set; }
        public DishSize Dishsize { get; set; }
    }

    public class Customer
    {
        //Create Order as an "EventHandler". The types of input parameters are "object" and "EventArgs".
        public event EventHandler Order;

        public void WalkIn()
        {
            Console.WriteLine("------The customer is coming------");
            Console.WriteLine("Walking in...");
        }

        public void Thinking()
        {
            Console.WriteLine("Thinking");
        }

        public void MakeOrder()
        {
            WalkIn();
            Thinking();
                        
            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.Dishname = "Beef";
                e.Dishsize = DishSize.Large;
                Console.WriteLine("\"I want to eat {0} in {1} size.\"", e.Dishname, e.Dishsize);
                Console.WriteLine();
                this.Order.Invoke(this, e);
            }
        }

        public double Bill { get; set; }

        public void PayTheBill()
        {
            Console.WriteLine("------The customer is eating------");
            Console.WriteLine("------The customer finishes eating------");
            Console.WriteLine("\"Good dish. I need to pay ${0} for that.\"", this.Bill);
        }

    }

    public class Waiter
    {
        //The types of input parameters need to be adjust to "object" and "EventArgs".
        internal void Action(object sender, EventArgs e)
        {
            //Use "as" to turn the input parameters to the types we need to use.
            Customer customer = sender as Customer;
            OrderEventArgs orderInfo = e as OrderEventArgs;

            double price = 30;
            switch (orderInfo.Dishsize)
            {
                case DishSize.Small:
                    price *= 0.75;
                    break;
                case DishSize.Medium:
                    break;
                case DishSize.Large:
                    price *= 1.5;
                    break;
                default:
                    break;
            }
            Console.WriteLine("\"I will serve you {0} in {1} size.\"", orderInfo.Dishname, orderInfo.Dishsize.ToString());
            Console.WriteLine("\"You need to pay ${0}.\"", price);
            Console.WriteLine();

            customer.Bill += price;
        }
        internal void Hello(object sender, EventArgs e)
        {
            Console.WriteLine("------The waiter is coming------");
            Console.WriteLine("\"Hello\"");
        }
    }

    public enum DishSize
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }
}
