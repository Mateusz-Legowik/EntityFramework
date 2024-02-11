using System;

namespace MATT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entity framework TEST");

            var database = new DatabaseContext();
            
            Book b = new Book()
            {
                Title = "Oda do młodości",
                Author = "Adam Mickiewicz",
                Price = 10,
                Description = "oda Adama Mickiewicza " +
                            "napisana 26 grudnia 1820"
            };
            
            database.Books.Add(b);
            database.SaveChanges();

            foreach (var book in database.Books)
            {
                Console.WriteLine($"Book Title : {book.Title} by " +
                                $"{book.Author}   {book.Price}$");
            }
        }
    }
}