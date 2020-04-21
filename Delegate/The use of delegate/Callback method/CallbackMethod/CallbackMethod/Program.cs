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
            ProductFactory pf = new ProductFactory();
            Retailer rtl = new Retailer();

            Func<Product> makepizza = new Func<Product>(pf.MakePizza);
            Func<Product> maketoy = new Func<Product>(pf.MakeToy);

            Logger logger = new Logger();
            Action<Product> showlog = new Action<Product>(logger.Log);

            Box boxPizza = rtl.SellProduct(makepizza, showlog);
            Box boxToy = rtl.SellProduct(maketoy, showlog);

            Console.WriteLine(boxPizza.Product.Name);
            Console.WriteLine(boxToy.Product.Name);
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product {0} is created at {1}. Price is {2}!", product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product() { Name = "Pizza", Price = 15 };
            return product;
        }
        public Product MakeToy()
        {
            Product product = new Product() { Name = "Toy", Price = 100 };
            return product;
        }
    }

    class Retailer
    {
        public Box SellProduct(Func<Product> ProductSth, Action<Product> CallLog)
        {
            Box box = new Box();
            Product product = ProductSth.Invoke();
            box.Product = product;
            if (product.Price > 50)
            {
                CallLog.Invoke(product);
            }
            return box;
        }
    }

}
