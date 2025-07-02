namespace BookDog.Domain.Entities
{
    public class Book
    {
        public string Title { get; set; }
        public List<string> Authors { get; set; } = new List<string>();
        public string Subtitle { get; set; }
        public string PublishYear { get; set; }
        public int PageCount { get; set; }
        public string ImageUrl { get; set; }

        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();

        public Book(string title, List<string> authors, string subtitle, string publishYear, int pageCount, string imageUrl)
        {
            Title = title;
            Authors = authors;
            Subtitle = subtitle;
            PublishYear = publishYear;
            PageCount = pageCount;
            ImageUrl = imageUrl;
        }
    }
}