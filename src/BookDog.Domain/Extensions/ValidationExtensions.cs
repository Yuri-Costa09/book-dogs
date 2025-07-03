using BookDog.Domain.Exceptions;

namespace BookDog.Domain.Extensions
{
    public static class ValidationExtensions
    {
        public static void ThrowIfNullOrEmpty(this string? value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new DomainException($"'{paramName}' is required.");
            }
        }
        
        public static void ThrowIfEmailInvalid(this string? email)
        {
            email.ThrowIfNullOrEmpty(email);
            
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new DomainException("Email is invalid.");
            }
        }

        public static void ThrowIfPasswordInvalid(this string? password)
        {
            password.ThrowIfNullOrEmpty(password);
            
            if (password.Length < 6)
            {
                throw new DomainException("Password must be at least 6 characters long.");
            }
        }
    }
}