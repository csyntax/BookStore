using BookStore.Models;

namespace BookStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("name=BookStoreContext")
        {

        }

        public IDbSet<Book> Books { get; set; }
        public IDbSet<Autor> Autors { get; set; }
      }
}