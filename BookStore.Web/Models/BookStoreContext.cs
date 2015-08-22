namespace BookStore.Web.Models
{
    using System;
    using System.Data.Entity;
    using BookStore.Models;

    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("name=BookStoreContext")
        {

        }

        public IDbSet<Book> Books { get; set; }
        public IDbSet<Autor> Autors { get; set; }
    }
}