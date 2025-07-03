using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class BookSession : BaseEntity
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public int PageCount { get; set; }
        public string ImageUrl { get; set; }
        public int TotalTimeRead { get; set; }
        public int TotalPagesRead { get; set; }
        public bool IsVisible { get; set; }
        
        public Tag? Tag { get; set; }
        public User User { get; set; }
        public List<Like> Likes { get; set; } = new List<Like>();

        public BookSession(User user, string name, string subtitle,
            string imageUrl) 
        {
            Name = name;
            Subtitle = subtitle;
            PageCount = 0;
            ImageUrl = imageUrl;
            TotalTimeRead = 0;
            TotalPagesRead = 0;
            IsVisible = true;
            User = user;
        }
    }
}