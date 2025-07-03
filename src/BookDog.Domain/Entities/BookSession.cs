using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class BookSession : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalTimeRead { get; set; }
        public int TotalPagesRead { get; set; }
        public bool IsVisible { get; set; }
        
        public Book Book { get; set; }
        public Tag? Tag { get; set; }
        public User User { get; set; }
        public List<Like> Likes { get; set; } = new List<Like>();

        public BookSession(Book book, User user, string name, string description) 
        {
            Name = name;
            Description = description;
            TotalTimeRead = 0;
            TotalPagesRead = 0;
            IsVisible = true;
            Book = book;
            User = user;
        }
    }
}