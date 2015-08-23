namespace BookStore.Models
{
    using System;
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public Categories Category { get; set; }
        public Autor Autor { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
