using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Small_Library_Mega
{
    public class MainMenu
    {
      public static  void Menu()
        {
            do
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search Book by Title or ID");
                Console.WriteLine("4. Borrow or Return Book");
                Console.WriteLine("5. Delete Book by ID");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        AddBook addBook = new AddBook();
                        addBook.AddNewBook();
                        break;
                    case "2":
                        ViewAllBooks viewAllBooks = new ViewAllBooks();
                        viewAllBooks.ViewBooks();
                        break;
                    case "3":
                        SearchOnBooks searchOnBooks = new SearchOnBooks();
                        searchOnBooks.SearchBooksByTitleorID();
                        break;
                    case "4":
                        BorrowOrReturn borrowOrReturn = new BorrowOrReturn();
                        borrowOrReturn.MenuBorrowOrReturn();
                        break;

                    case "5":
                        DeleteBook deleteBook = new DeleteBook();
                        deleteBook.DeleteBooksByID();
                        break;
                        
                    case "6":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
               
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();

            } while(true);
        }
    }
}
