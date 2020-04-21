using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//This program shows why "event" is an important feature.
namespace Declaration3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();

            Customer badGuy = new Customer();

            badGuy.Order += waiter.Action;

            OrderEventArgs e1 = new OrderEventArgs();
            e1.Dishname = "Duck";
            e1.Dishsize = DishSize.Large;

            OrderEventArgs e2 = new OrderEventArgs();
            e2.Dishname = "Pork";
            e2.Dishsize = DishSize.Small;

            //As "Order" becomes a public field, it can be quoted outside the class, which means an event
            //could be invoked by any instances with any EventArgs.
            //As in this example, the customer does not order anything. 
            //But the badGuy does in the name of the customer.
            //That kind of mess will bring troubles.
            badGuy.Order.Invoke(customer, e1);
            badGuy.Order.Invoke(customer, e2);
        }
    }

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class OrderEventArgs : EventArgs
    {
        public string Dishname { get; set; }
        public DishSize Dishsize { get; set; }
    }

    public class Customer
    {
        //Here "Order" is no long an event but normal field.
        public OrderEventHandler Order;

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

            //"this.Order" is a syntax error if we do not use the easier way to declare an event.
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
        internal void Action(Customer customer, OrderEventArgs e)
        {
            double price = 30;
            switch (e.Dishsize)
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
            Console.WriteLine("\"I will serve you {0} in {1} size.\"", e.Dishname, e.Dishsize.ToString());
            Console.WriteLine("\"You need to pay ${0}.\"", price);
            Console.WriteLine();

            customer.Bill += price;
        }
        internal void Hello(Customer customer, OrderEventArgs e)
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
