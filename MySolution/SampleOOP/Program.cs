using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    public class Product
    {
        private string ProductName;
        public Product()
        {
            ProductName = "New product";
        }
        public Product(string ProductName)
        {
            this.ProductName = ProductName;
        }
        public void PrintProduct()
        {
            //Console.WriteLine("Product name: {0}", ProductName); this is the same but this code below is better
            Console.WriteLine($"Product name: {ProductName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product obj = new Product();
            obj.PrintProduct();
        }
    }
}
