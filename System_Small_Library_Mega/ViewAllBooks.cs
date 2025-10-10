using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Small_Library_Mega
{
    public class ViewAllBooks
    {
        public void ViewBooks()
        {
            foreach( var book in AddBook.books)
            {
                Console.WriteLine($"ID: {book.Id.ToString().PadRight(7)}| Title: {book.Title.PadRight(20)} |Author: {book.Author.PadRight(15)}| Year: {book.year.ToString().PadRight(4)}| Available: {book.IsAvailable}");
            }
        }
    }
}
