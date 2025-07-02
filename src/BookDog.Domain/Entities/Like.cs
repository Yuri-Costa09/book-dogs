using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class Like : BaseEntity
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