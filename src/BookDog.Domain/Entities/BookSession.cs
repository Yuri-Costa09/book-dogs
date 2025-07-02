namespace BookDog.Domain.Entities
{
    public class BookSession
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalTimeRead { get; set; }
        public bool IsVisible { get; set; }

        public Tag? Tag { get; set; }
        public User User { get; set; }
        public List<Like> Likes { get; set; } = new List<Like>();

        public BookSession(string name, string description)
        {
            Name = name;
            Description = description;
            TotalTimeRead = 0;
            IsVisible = true;
        }
    }
}