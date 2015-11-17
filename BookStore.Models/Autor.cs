using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Autor
    {
        private ICollection<Book> books;

        public Autor()
        {
            this.books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }
    }
}
