using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class ReadingSession : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int TotalTimeRead { get; set; }
        public int TotalPagesRead { get; set; }
        
        public BookSession BookSession { get; set; }
    }
}