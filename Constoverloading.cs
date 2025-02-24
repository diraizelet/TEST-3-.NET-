namespace Constoverloading
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            ISBN = "Unknown";
        }

        // Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "Unknown";
        }

        // Constructor with Title, Author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
}
