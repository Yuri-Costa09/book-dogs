namespace BookDog.Domain.Entities
{
    public class Like
    {
        public BookSession BookSession { get; set; }
        public User User { get; set; }

        public Like(BookSession bookSession, User user)
        {
            BookSession = bookSession;
            User = user;
        }
    }
}