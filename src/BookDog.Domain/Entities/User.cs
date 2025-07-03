using BookDog.Domain.Shared;

namespace BookDog.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHashed { get; set; }
        public string Role { get; set; } = "User";

        public User(string name, string email, string phoneNumber, string passwordHashed)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            PasswordHashed = passwordHashed;
        }

        //? RELATIONS
        // 1. User has one Profile
        // 2. User has many BookSessions
        public Profile Profile { get; set; }
        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();
    }
}