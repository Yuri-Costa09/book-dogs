using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IUserRepository
    {
        public Task<User> GetUserById(Guid id);
        public Task<User> GetUserByEmail(string email);
        public Task<List<User>> GetAllUsers();
        public void CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(Guid id);
    }
}