using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    interface IUserRepository
    {
        Task<User> GetUserById(Guid id);
        Task<User> GetUserByEmail(string email);
        Task<List<User>> GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}