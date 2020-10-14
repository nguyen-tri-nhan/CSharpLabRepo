using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class MyBooklib
    {
        string id, name, publisher;
        double price;

        public MyBooklib(string id, string name, string publisher, double price)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public double Price { get => price; set => price = value; }

        public void display()
        {
            Console.WriteLine($"bookid: {this.id}");
            Console.WriteLine($"Title: {this.name}");
            Console.WriteLine($"Publisher: {this.publisher}");
            Console.WriteLine($"Price: {this.price}");
            Console.WriteLine();
        }

        public void display(string id)
        {
            Console.WriteLine($"bookid: {this.id}");
            Console.WriteLine($"Title: {this.name}");
            Console.WriteLine($"Publisher: {this.publisher}");
            Console.WriteLine($"Price: {this.price}");
            Console.WriteLine();
        }


    }
}
