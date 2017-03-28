using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary
{
    class MainPageData
    {
        public String searchTerm { get; set; } = "Placeholder for what was searched";

        public List<BookModel> Books { get; set; }

        public MainPageData()
        {
            Books = new List<BookModel>();

            Books.Add(new OpenLibrary.BookModel("Book a", 1984, "john smith"));
            Books.Add(new OpenLibrary.BookModel("Book b", 2010, "alex jones"));
            Books.Add(new OpenLibrary.BookModel("Book c", 2000, "jim johnson"));
            Books.Add(new OpenLibrary.BookModel("Book d", 2002, "jay smith"));
            Books.Add(new OpenLibrary.BookModel("Book e", 1991, "michael johnson"));

        }
    }
}
