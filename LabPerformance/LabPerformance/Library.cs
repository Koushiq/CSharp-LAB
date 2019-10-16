using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPerformance
{
    class Library
    {
        private String libraryName;
        private Book[] books;
        private int arrayCounter;
        private int sizeOfArray;
        public String LibraryName
        {
            set
            {
                this.libraryName = value;
            }
            get
            {
                return this.libraryName;
            }
        }
        public int SizeOfArray
        {
            set
            {
                this.sizeOfArray = value;
            }
            get
            {
                return this.sizeOfArray;
            }
        }

        public Library()
        {

        }
        public Library(String libraryName, int sizeOfArray)
        {
            this.LibraryName = libraryName;
            this.SizeOfArray = sizeOfArray;
            this.books = new Book[this.SizeOfArray];
            this.arrayCounter = 0;
        
        }


        public void AddBook(Book b)
        {
            if(this.arrayCounter <= this.SizeOfArray)
            {
               this.books[this.arrayCounter++] = b;
            }
            else
            {
                Console.WriteLine("Can't Add Max limit reached !");
            }
        }
        public void RemoveBook(Book b)
        {
            bool flag=false;
            for(int i=0;i<books.Length;i++)
            {
                if(this.books[i]==b)
                {
                    flag = true;
                    this.books[i] = null;
                    Console.WriteLine("Book removed!");
                }
            }
            if(flag==false)
            {
                Console.WriteLine("Book not found!");
            }
        }
        public Book SearchBook(int bookId)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].BookId == bookId)
                {
                    return books[i];
                }
            }
            return null;
        }
       

        public void ChangeBookCopy(Book b,int copy,int flag)
        {
            if(flag==1)
            {
               b.AddNumberOfCopies(copy);
            }
            else
            {
               b.ReduceNumberOfCopies(copy);
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Displaying Library Info!");
            Console.WriteLine();
            Console.WriteLine("Library Name "+ this.libraryName);
            Console.WriteLine();
            Console.WriteLine("Displaying Books info !");
            for (int i=0;i<this.books.Length;i++)
            {
                if(this.books[i]!=null)
                {
                    books[i].Display();
                }
            }
        }

        
    }
}
