using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface ILikeRepository
    {
        public Task<Like> GetLikeById(Guid id);
        public Task<List<Like>> GetLikesByBookSessionId(Guid bookSessionId);
        public Task<List<Like>> GetLikesByUserId(Guid userId);
        public void CreateLike(Like like);
        public void DeleteLike(Guid id);
    }
}