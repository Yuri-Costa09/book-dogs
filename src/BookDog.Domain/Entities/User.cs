using BookDog.Domain.Shared;
using BookDog.Domain.Extensions;

namespace BookDog.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User";

        public User(string name, string email, string phoneNumber, string passwordHash)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            PasswordHash = passwordHash;
        }
        
        public static User Create(string name, string email, string phoneNumber, string PasswordHash)
        {
            name.ThrowIfNullOrEmpty(name);
            email.ThrowIfEmailInvalid();
            phoneNumber.ThrowIfNullOrEmpty(phoneNumber); 
            PasswordHash.ThrowIfPasswordInvalid();
            
            return new User(name, email, phoneNumber, PasswordHash);
        }

        //! MANDATORY:
        // When user registers, a profile is created for them 
        public Profile Profile { get; set; }
        public List<BookSession> BookSessions { get; set; } = new List<BookSession>();
    }
}