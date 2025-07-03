namespace BookDog.Domain.Interfaces
{
    public interface IPasswordChecker
    {
        bool VerifyPassword(string plainPassword, string hashedPassword);
    }
}