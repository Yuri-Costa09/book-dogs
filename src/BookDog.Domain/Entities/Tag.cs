using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();

        public Tag(string name)
        {
            Name = name;
        }
    }
}