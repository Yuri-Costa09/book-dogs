namespace BookDog.Domain.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "User";

        public User(string name, string email, string phoneNumber, string password)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        //? RELATIONS
        // 1. User has one Profile
        // 2. User has many BookSessions
        public Profile Profile { get; set; }
        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();
    }
}