using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductfactory pf = new PizzaFactory();
            IProductfactory tf = new ToyFactory();
            Retailer rtl = new Retailer();
            
            Box boxPizza = rtl.SellProduct(pf);
            Box boxToy = rtl.SellProduct(tf);

            Console.WriteLine(boxPizza.Product.Name);
            Console.WriteLine(boxToy.Product.Name);
        }
    }

    interface IProductfactory
    {
        Product make();
    }

    class PizzaFactory : IProductfactory
    {
        public Product make()
        {
            Product product = new Product() { Name = "Pizza" };
            return product;
        }
    }

    class ToyFactory : IProductfactory
    {
        public Product make()
        {
            Product product = new Product() { Name = "Toy" };
            return product;
        }
    }

    class Product
    {
        public string Name { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class Retailer
    {
        public Box SellProduct(IProductfactory product)
        {
            Box box = new Box();
            box.Product = product.make();
            return box;
        }
    }

}
