using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserById(Guid id);
        Task<User?> GetUserByEmail(string email);
        Task<List<User>> GetAllUsers();
        Task CreateUser(User user);
        Task UpdateUser(User? user);
        Task DeleteUser(Guid id);
    }
}