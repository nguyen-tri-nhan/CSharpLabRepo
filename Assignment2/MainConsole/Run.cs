using MyBookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Run
    {
        static void Main(string[] args)
        {
            string id, name, publisher;
            double price;
            string input = null;
            string show = "*****FPT LIB IN A NUTSHELL*******\n"
                            + "1. Add new book\n"
                            + "2.Update a book\n"
                            + "3.Delete a book\n"
                            + "4.List all book\n"
                            + "5.Quit\n";
            while (true)
            {
                Console.WriteLine(show);
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("id: ");
                        while (true)
                        {
                            id = Console.ReadLine();
                            if (!MyBookList.searchBook(id))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("This id is already appeareance! please choose another ID");
                            }
                        }
                        Console.Write("name: ");
                        name = Console.ReadLine();
                        Console.Write("publisher: ");
                        publisher = Console.ReadLine();
                        Console.Write("price: ");
                        while (true)
                        {
                            try
                            {
                                price = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid input, price is a double");
                            }
                        }
                        Console.WriteLine("Do you want to add? Y/N");
                        string confirmation = Console.ReadLine().ToLower();
                        if(confirmation == "y")
                        {
                            MyBookList.addBook(new MyBooklib(id, name, publisher, price));
                            Console.WriteLine("ADDED");
                        }
                        else
                        {
                            Console.WriteLine("NOT ADDED");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("id: ");
                        while (true)
                        {
                            id = Console.ReadLine();
                            if (MyBookList.searchBook(id))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ID not found");
                            }
                        }
                        Console.Write("name: ");
                        name = Console.ReadLine();
                        Console.Write("publisher: ");
                        publisher = Console.ReadLine();
                        Console.Write("price: ");
                        while (true)
                        {
                            try
                            {
                                price = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid input, price is a double");
                            }
                        }
                        Console.WriteLine("Do you want to update? Y/N");
                        confirmation = Console.ReadLine().ToLower();
                        if (confirmation == "y")
                        {
                            MyBookList.updateBook(new MyBooklib(id, name, publisher, price));
                            Console.WriteLine("UPDATED");
                        } else
                        {
                            Console.WriteLine("Not updated");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        while (true)
                        {
                            id = Console.ReadLine();
                            if (MyBookList.searchBook(id))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ID not found");
                            }
                        }
                        Console.WriteLine("Do you want to delete? Y/N");
                        confirmation = Console.ReadLine().ToLower();
                        if (confirmation == "y")
                        {
                            MyBookList.deleteBook(id);
                            Console.WriteLine("DELETED");
                        } else
                        {
                            Console.WriteLine("Not deleted");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        MyBookList.displayList();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("Do you want to exit? Y/N");
                        confirmation = Console.ReadLine().ToLower();
                        if (confirmation == "y")
                        {
                            Console.WriteLine("Goodbye");
                            Console.ReadLine();
                            Environment.Exit(0);
                        } else
                        {
                            Console.Clear();
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
        
    }
}
