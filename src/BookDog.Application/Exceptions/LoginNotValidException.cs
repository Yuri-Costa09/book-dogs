namespace BookDog.Application.Exceptions
{
    public class LoginNotValidException : Exception
    {
        public string Email { get; }

        public LoginNotValidException(string email)
            : base($"Login not valid for user with email '{email}'.")
        {
            Email = email;
        }
    }
}