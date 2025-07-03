using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface ITagRepository
    {
        Task<Tag> GetTagById(Guid id);
        Task<Tag> GetTagByName(string name);
        Task<List<Tag>> GetAllTags();
        Task CreateTag(Tag tag);
        Task UpdateTag(Tag tag);
        Task DeleteTag(Guid id);
    }
}