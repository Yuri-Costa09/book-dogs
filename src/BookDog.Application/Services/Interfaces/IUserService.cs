namespace BookDog.Application.Services.Interfaces
{
    public interface IUserService
    {
        void Register(string name, string email, string phoneNumber, string password);
        void Login(string email, string password);
        void UpdateUser(Guid userId, string name, string email, string phoneNumber);
        void DeleteUser(Guid userId);
    }
}