using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System_Small_Library_Mega
{
    public class BorrowOrReturn
    {
        public void MenuBorrowOrReturn()
        {
            Console.WriteLine("1. Borrow Book");
            Console.WriteLine("2. Return Book");
            Console.WriteLine("3. Back to Main Menu");
            Console.WriteLine("Enter your choice:");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    BorrowBook();
                    break;
                case "2":
                    ReturnBook();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public void BorrowBook()
        {

            try
            {
                Console.WriteLine("Enter Book ID to borrow:");
                int bookId = int.Parse(Console.ReadLine());
                foreach (var book in AddBook.books)
                {
                    if (book.Id == bookId)
                    {
                        if (book.IsAvailable)
                        {
                            book.IsAvailable = false;
                            Console.WriteLine("Book borrowed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, this book is currently not available.");
                        }
                        return;
                    }
                }
                Console.WriteLine("Book not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void ReturnBook()
        {
            try
            {
                Console.WriteLine("Enter Book ID to return:");
                int bookId = int.Parse(Console.ReadLine());
                foreach (var book in AddBook.books)
                {
                    if (book.Id == bookId)
                    {
                        if (!book.IsAvailable)
                        {
                            book.IsAvailable = true;
                            Console.WriteLine("Book returned successfully!");
                        }
                        else
                        {
                            Console.WriteLine("This book was not borrowed.");
                        }
                        return;
                    }
                }
                Console.WriteLine("Book not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
