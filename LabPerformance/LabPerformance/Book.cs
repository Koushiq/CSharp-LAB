using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPerformance
{
    class Book
    {
        private int bookId=0;
        public static int bookCounter=0;
        private String bookTitle;
        private String aurthorName;
        private int numberOfCopies;
        
        public Book() { }

        public Book(String bookTitle,String aurthorName,int numberOfCopies)
        {
            bookCounter++;
            this.bookId = bookCounter;
            this.BookTitle = bookTitle;
            this.AurthorName = aurthorName;
            this.NumberOfCopies = numberOfCopies;

        }
        public int BookId
        {
            get
            {
                return this.bookId;
            }
        }
        public String BookTitle
        {
            set
            {
                this.bookTitle = value;
            }
            get
            {
                return this.bookTitle;
            }
        }
        public String AurthorName
        {
            set
            {
                this.aurthorName = value;
            }
            get
            {
                return this.aurthorName;
            }
        }
        public int NumberOfCopies
        {
            set
            { 
                if(value>=0)
                {
                    this.numberOfCopies = value;
                }
                else
                {
                    this.numberOfCopies = 0; // minimum 10 copies 
                }
                 
            }
            get
            {
                return this.numberOfCopies;
            }
        }
       
        public void AddNumberOfCopies(int copy)
        {
            this.NumberOfCopies += copy;
        }
        public void ReduceNumberOfCopies(int copy)
        {
            this.NumberOfCopies -= copy;
        }
        public void Display()
        {
            
            Console.WriteLine();
            Console.WriteLine("Book Id "+ this.BookId);
            Console.WriteLine("Book Title "+ this.BookTitle);
            Console.WriteLine("Aurthor Name "+ this.AurthorName);
            Console.WriteLine("No Of Copies "+ this.NumberOfCopies);
            Console.WriteLine();
        }
    }
}
