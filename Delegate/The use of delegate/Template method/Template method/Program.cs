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

            Box boxPizza = rtl.SellProduct(makepizza);
            Box boxToy = rtl.SellProduct(maketoy);

            Console.WriteLine(boxPizza.Product.Name);
            Console.WriteLine(boxToy.Product.Name);
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

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product() { Name = "Pizza" };
            return product;
        }
        public Product MakeToy()
        {
            Product product = new Product() { Name = "Toy" };
            return product;
        }
    }

    class Retailer
    {
        public Box SellProduct(Func<Product> ProductSth)
        {
            Box box = new Box();
            box.Product = ProductSth.Invoke();
            return box;
        }
    }
   
}
