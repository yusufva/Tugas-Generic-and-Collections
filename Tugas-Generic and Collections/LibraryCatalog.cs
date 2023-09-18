using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Generic_and_Collections
{
    interface ILibraryCatalog<T> //Interface Contract method untuk LibraryCatalog
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
        T FindBook(string title);
        void ListBooks();
    }

    public class LibraryCatalog : ILibraryCatalog<Book> //class LibraryCatalog implement Interface ILibraryCatalog
    {
        private List<Book> books; //pendeklarasian variabel books

        //constructor LibraryCatalog
        public LibraryCatalog()
        {
            books = new List<Book>();
        }

        //Implementasi method dari interface contruct
        public void ListBooks()
        {
            Console.WriteLine("List of Books in Library Catalog:");
            foreach (var book in books) //perulangan untuk menampilkan buku
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publication Year: {book.PublicationYear}");
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book); //menambahkan buku dalam list menggunakan function add
        }

        public Book FindBook(string title)
        {
            return books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase)); //function mencari buku dengan function find
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);  //function untuk menghapus buku dari list menggunakan remove
        }
    }
}
