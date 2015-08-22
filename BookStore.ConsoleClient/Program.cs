namespace BookStore.ConsoleClient
{
    using System;
    using BookStore.Models;
    using BookStore.Data;
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BookStoreContext();

            var book = db.Books.Add(new Book()
            {
                Title = "Intro C# Book",
                Price = 10.0f,
                Autor = new Autor
                {
                    FirstName = "Svetlin",
                    LastName = "Nakov"
                },
                Category = Categories.Software,
                ReleaseDate = new DateTime(2010, 10, 10)
            });

            db.SaveChanges();
        }
    }
}
