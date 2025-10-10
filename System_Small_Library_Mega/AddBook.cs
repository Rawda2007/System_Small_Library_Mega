using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace System_Small_Library_Mega
{
    public class AddBook    
    {
     public static List<EntityBook> books = new List<EntityBook>();
        public void AddNewBook()
        {
            try { 
            EntityBook newBook = new EntityBook();
            Console.WriteLine("Enter Book ID:");
            newBook.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Title:");
            newBook.Title = Console.ReadLine();
            Console.WriteLine("Enter Book Author:");
            newBook.Author = Console.ReadLine();
            Console.WriteLine("Enter Book Year:");
            newBook.year = int.Parse(Console.ReadLine());
            newBook.IsAvailable = true;
            books.Add(newBook);
            Console.WriteLine("Book added successfully!");
        }
            
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
}
}