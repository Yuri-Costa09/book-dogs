using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class ReadingSession : BaseEntity
    {
        public string Name { get; set; }
        public string? Content { get; set; }
        public int TimeRead { get; set; }
        public int PagesRead { get; set; }
        
        public BookSession BookSession { get; set; }
        
        public ReadingSession(BookSession bookSession, string name, string? content)
        {
            BookSession = bookSession;
            Name = name;
            Content = content;
            TimeRead = 0;
            PagesRead = 0;
        }
    }
}