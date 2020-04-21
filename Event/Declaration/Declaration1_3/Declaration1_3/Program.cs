using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Declaration
{
    //All classes must all be public.
    public class Program
    {
        static void Main(string[] args)
        {
            //7. create subscription.
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Hello;
            customer.Order += waiter.Action;
            //13. trigger the method that's going to invoke the event.
            customer.MakeOrder();
            //17. customer pays the bill.
            customer.PayTheBill();
        }
    }

    //1. create delegate class.
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    //3. create class "OrderEventArgs". Customized EventArgs must be a child of EventArgs.(a recognized rule)
    //10. create the properties in "OrderEventArgs"
    public class OrderEventArgs : EventArgs
    {
        public string Dishname { get; set; }
        public DishSize Dishsize { get; set; }
    }

    //2. create class "Customer".
    public class Customer
    {
        //4. create a delegate field to store the relationships. This must be private to prevent other public quote.
        private OrderEventHandler orderEventHandler;
        //5. create the order event.
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

        //8. create some processing steps.
        public void WalkIn()
        {
            Console.WriteLine("------The customer is coming------");
            Console.WriteLine("Walking in...");
        }

        public void Thinking()
        {
            Console.WriteLine("Thinking");
        }

        //11. invoke the event.
        public void MakeOrder()
        {
            WalkIn();
            Thinking();
            if (orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.Dishname = "Beef";
                e.Dishsize = DishSize.Large;
                Console.WriteLine("\"I want to eat {0} in {1} size.\"", e.Dishname, e.Dishsize);
                Console.WriteLine();
                orderEventHandler.Invoke(this, e);
            }
        }

        //14. create field "Bill" to preserve the money.
        public double Bill { get; set; }

        //16. customer needs to pay the bill
        public void PayTheBill()
        {
            Console.WriteLine("------The customer is eating------");
            Console.WriteLine("------The customer finishes eating------");
            Console.WriteLine("\"Good dish. I need to pay ${0} for that.\"", this.Bill);
        }

    }

    //6. create the subscriber of the event.
    public class Waiter
    {
        //12. add detail to the event handler.
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

            //15. Send the bill back.
            customer.Bill += price;
        }
        //This is just a test for one event source with multiple event subscriber.
        internal void Hello(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("------The waiter is coming------");
            Console.WriteLine("\"Hello\"");
        }
    }

    //9. create an enum for dishsize
    public enum DishSize
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }
}
