using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_App_Week9
{
    public static class Data
    {
        static ObservableCollection<Book> books;

        static Data()
        {
            books = new ObservableCollection<Book>();
            books.Add(new Book("Elf Stone", "Terry Books"));
            
            
        }

        public static ObservableCollection<Book> Books {  get { return books; } }

        public static void AddBook(string title, string author)
        {
            books.Add(new Book(title, author));
        }
    }
}
