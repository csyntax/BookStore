using System;
using System.Data.Entity;
using BookStore.Models;

namespace BookStore.Data
{
	public class BookStoreContext : DbContext
	{
		public BookStoreContext() : base("BookStore")
		{

		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Autor> Autors { get; set; }
	  }
}