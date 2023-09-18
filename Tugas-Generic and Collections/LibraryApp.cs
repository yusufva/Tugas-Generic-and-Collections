namespace Tugas_Generic_and_Collections
{
    internal class LibraryApp
    {
        static void Main(string[] args)
        {
            LibraryCatalog catalog = new LibraryCatalog(); //instansiasi LibraryCatalog

            while (true) //loop menu aplikasi
            {
                //tampilan pilihan menu utama
                Console.WriteLine("\nLibrary Catalog Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Find Book by Title");
                Console.WriteLine("4. List All Books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice; //deklarasi variabel choice
                if (int.TryParse(Console.ReadLine(), out choice)) //pengkondisian pemilihan menu dengan function TryParse agar tidak terjadi error saat melakukan parse
                {
                    switch (choice) //decission dari menu
                    {
                        case 1://case pemilihan menu 1
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine(); //input untuk title
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine(); //input untuk author
                            Console.Write("Enter Publication Year: ");
                            int publicationYear; 
                            if (int.TryParse(Console.ReadLine(), out publicationYear)) //input untuk publicationYear dengan TryParse
                            {
                                Book newBook = new Book(title, author, publicationYear); //instansiasi objek buku baru
                                catalog.AddBook(newBook); //pemanggilan method untuk menambah buku
                                Console.WriteLine("Book added to the catalog.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for Publication Year."); //tampilan jika publicationYear bukan integer
                            }
                            break; //break switch case
                        case 2: //case pemilihan menu 2
                            Console.Write("Enter Title of the Book to Remove: ");
                            string titleToRemove = Console.ReadLine(); //input untuk menghapus buku berdasar judul
                            Book bookToRemove = catalog.FindBook(titleToRemove); //method untuk mencari judul berdasar buku
                            if (bookToRemove != null) //pengkondisian jika judul tidak kosong
                            {
                                catalog.RemoveBook(bookToRemove); //method untuk menghapus buku
                                Console.WriteLine("Book removed from the catalog."); //notifikasi menghapus buku
                            }
                            else
                            {
                                Console.WriteLine("Book not found in the catalog."); //notifikasi buku tidak ditemukan
                            }
                            break; //break switch case
                        case 3: //case pemilihan menu 3
                            Console.Write("Enter Title of the Book to Find: ");
                            string titleToFind = Console.ReadLine(); //input judul untuk dicari
                            Book foundBook = catalog.FindBook(titleToFind); //pemanggilan method untuk mencari buku
                            if (foundBook != null)
                            {
                                Console.WriteLine($"Book Found - Title: {foundBook.Title}, Author: {foundBook.Author}, Publication Year: {foundBook.PublicationYear}");
                            }
                            else
                            {
                                Console.WriteLine("Book not found in the catalog.");
                            }
                            break; //break switch case
                        case 4: //case pemilihan menu 4
                            catalog.ListBooks(); //pemanggilan method ListBook
                            break; //break switch case
                        case 5: //case pemilihan menu 5
                            Environment.Exit(0);  //function untuk menghentikan program
                            break; //break switch case
                        default: //case menu default
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break; //break switch case
                    }
                }
                else //kondisi ketika input tidak sesuai
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }
        }
    }
}