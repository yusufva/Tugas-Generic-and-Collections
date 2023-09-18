using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Generic_and_Collections
{
    public class Book //class book yang akan dijadikan object book
    {
        public Book(string title, string author, int publicationYear) //constructor class book dengan parameter title author dan publicationYear
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        //pendeklarasian variabel pada class book
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
    }
}
