namespace BookDog.Domain.Entities
{
    public class Tag
    {
        public string Name { get; set; }

        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();

        public Tag(string name)
        {
            Name = name;
        }
    }
}