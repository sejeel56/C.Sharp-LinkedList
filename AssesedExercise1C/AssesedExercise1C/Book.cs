using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesedExercise1C
{
    class Book : IComparable
    {
        
        private string isbn, title;
        public Book(string isbn, string title)
        {
            this.isbn = isbn;
            this.title = title;
        }
   
        

        public string ISBN
        {
            set { this.isbn = value; }
            get { return this.isbn; }
        }
        public string Title
        {
            set { this.title = value; } 
            get { return this.title; }
        }
        public override string ToString()
        {
           // return isbn.ToString();
           return this.Title+" "+this.ISBN;
        }


        public int CompareTo(Object obj)
        {
            Book other = (Book)obj;
            return this.isbn.CompareTo(other.isbn);
        }

      
    }

}
