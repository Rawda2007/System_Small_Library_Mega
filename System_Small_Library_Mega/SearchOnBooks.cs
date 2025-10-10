using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Small_Library_Mega
{
    public class SearchOnBooks
    {
        public void SearchBooksByTitleorID()
        {
            Console.WriteLine("Enter Book Title or ID to search:");
            string input = Console.ReadLine();
            bool isIdSearch = int.TryParse(input, out int bookId);
            if (isIdSearch)
            {
                foreach(var book in AddBook.books)
                {
                    if (book.Id == bookId)
                    {
                        Console.WriteLine($"ID: {book.Id.ToString().PadRight(7)},| Title: {book.Title.PadRight(20)}, |Author: {book.Author.PadRight(15)},| Year: {book.year.ToString().PadRight(4)},| Available: {book.IsAvailable}");
                        return;
                    }
                }
            }
            else
            {
                foreach (var book in AddBook.books)
                {
                    if (book.Title == input)
                    {
                        Console.WriteLine($"ID: {book.Id.ToString().PadRight(7)},| Title: {book.Title.PadRight(20)}, |Author: {book.Author.PadRight(15)},| Year: {book.year.ToString().PadRight(4)},| Available: {book.IsAvailable}");
                        return;
                    }
                }
            }
            Console.WriteLine("Book not found.");
        }
    }
}
