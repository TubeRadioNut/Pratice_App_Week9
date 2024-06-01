using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_App_Week9
{
    public class Book
    {
        //fields
        string _title;
        string _author;
        //constructor
        public Book(string title, string author)
        {
            _title = title;
            _author = author;
        }
        //default constructor
        public Book()
        {
            _title = "Placeholder Book";
            _author = "Placeholder Author";
        }
        //properties
        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }


    }
}
