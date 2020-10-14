using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            int age = 0;
            string address = null;
            int balance = 0;
            bool transaction = false;
            String input = null;
            String atmInput = null;
            int amount = 0;
            while (true)
            {
                Console.WriteLine("*** Welcome to Haichan Bank ***");
                Console.WriteLine("1. Open");
                Console.WriteLine("2. Account");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "open":
                        Console.WriteLine("*** Open account ***");
                        Console.WriteLine("Enter your name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your address");
                        address = Console.ReadLine();
                        transaction = true;
                        Console.WriteLine("Open new account successful...");
                        Console.WriteLine("Account detail: ");
                        Console.WriteLine("Name: " + name);
                        Console.WriteLine("Age: " + age);
                        Console.WriteLine("Address: " + address);
                        break;
                    case "account":
                        if (!transaction)
                        {
                            Console.WriteLine("You have to open new account first");
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("*** Execuse transaction ***");
                                Console.WriteLine("2.1: Deposit");
                                Console.WriteLine("2.2: Withdraw");
                                Console.WriteLine("2.3: Show");
                                Console.WriteLine("2.4: Quit");
                                Console.WriteLine("Input tranaction type");
                                atmInput = Console.ReadLine();
                                switch (atmInput.ToLower())
                                {
                                    case "deposit":
                                        Console.WriteLine("Enter amount to dep ");
                                        amount = Convert.ToInt32(Console.ReadLine());
                                        if (amount > 0)
                                        {
                                            balance += amount;
                                            Console.WriteLine("Deposit success");
                                        } 
                                        else
                                        {
                                            Console.WriteLine("Deposit fail! Amount must greater than 0\n");
                                        }
                                        break;
                                    case "withdraw":
                                        Console.WriteLine("Enter amount to withdraw");
                                        amount = Convert.ToInt32(Console.ReadLine());
                                        if (balance >= amount)
                                        {
                                            balance -= amount;
                                            Console.WriteLine("SuccesS");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Failed. The amount mut not bet greater than balance");
                                        }
                                        break;
                                    case "show":
                                        Console.WriteLine("Current balace is "+ balance+"\n");
                                        break;
                                    case "quit":
                                        break;
                                }
                            } while (!atmInput.Equals("quit"));
                            break;
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Thank you");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
    }
}
