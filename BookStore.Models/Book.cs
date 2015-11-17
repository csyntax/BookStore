using System;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Autor Autor { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
