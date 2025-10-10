using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Small_Library_Mega
{
    public class DeleteBook
    {
        public void DeleteBooksByID()
        {
            try
            {
                Console.WriteLine("Enter Book ID to delete:");
                int bookId = int.Parse(Console.ReadLine());
                foreach (var book in AddBook.books)
                {
                    if (book.Id == bookId)
                    {
                        AddBook.books.Remove(book);
                        Console.WriteLine("Book deleted successfully!");
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
