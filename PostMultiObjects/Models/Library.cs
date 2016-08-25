namespace PostMultiObjects.Models
{
    using System.Collections.Generic;

    public class Library
    {
        public Library()
        {
            this.Books = new List<Book>();
        }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
