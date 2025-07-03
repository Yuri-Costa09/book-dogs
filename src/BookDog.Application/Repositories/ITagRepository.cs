using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface ITagRepository
    {
        Task<Tag> GetTagById(Guid id);
        Task<Tag> GetTagByName(string name);
        Task<List<Tag>> GetAllTags();
        void CreateTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(Guid id);
    }
}