using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPerformance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("AIUB Library",10);
            Book b1 = new Book("Physics","Toffazul Haque",12);
            Book b2 = new Book("Chemistry", "Mazhar", 11);
            Book b3 = new Book("Higher Math", "M.M Hasan", 19);
            Book b4 = new Book("English","Murad Hasan",11);
            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            library.DisplayInfo();

            library.SearchBook(b2.BookId);
            library.ChangeBookCopy(b2,5,1);
            library.SearchBook(b3.BookId);
            library.ChangeBookCopy(b3, 5, 0);
            library.DisplayInfo();
            library.RemoveBook(b1);
            library.AddBook(b4);
            library.DisplayInfo();
           
        }
    }
}
