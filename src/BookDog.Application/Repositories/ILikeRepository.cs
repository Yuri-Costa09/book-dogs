using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface ILikeRepository
    {
        Task<Like> GetLikeById(Guid id);
        Task<List<Like>> GetLikesByBookSessionId(Guid bookSessionId);
        Task<List<Like>> GetLikesByUserId(Guid userId);
        void CreateLike(Like like);
        void DeleteLike(Guid id);
    }
}