using BookDog.Domain.Shared;
using BookDog.Domain.Extensions;

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

        public static User Create(string name, string email, string phoneNumber, string plainPassword)
        {
            name.ThrowIfNullOrEmpty(name);
            email.ThrowIfEmailInvalid();
            phoneNumber.ThrowIfNullOrEmpty(phoneNumber);
            plainPassword.ThrowIfPasswordInvalid();
            
            return new User(name, email, phoneNumber, plainPassword);
        }

        //! MANDATORY:
        // When user registers, a profile is created for them 
        public Profile Profile { get; set; }
        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();
    }
}