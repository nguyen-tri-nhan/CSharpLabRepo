using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class MyBookList
    {
        static Dictionary<string, MyBooklib> bookList = new Dictionary<string, MyBooklib>();
        public static void displayList()
        {
            foreach(MyBooklib book in bookList.Values)
            {
                book.display();
            }
        }
        public static bool searchBook(string id)
        {
            return bookList.ContainsKey(id);
        }
        public static void addBook(MyBooklib book)
        {
            bookList.Add(book.Id,book);
        }
        public static void deleteBook(string id)
        {
            bookList.Remove(id);
        }
        public static void updateBook(MyBooklib book)
        {
            bookList[book.Id] = new MyBooklib(book.Id, book.Name, book.Publisher, book.Price);
        }
    }
}
