namespace BookDog.Domain.Interfaces
{
    public interface IPasswordHasher
    {
        string Hash(string password);
    }
}