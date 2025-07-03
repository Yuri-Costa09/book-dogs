using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface ITagRepository
    {
        public Task<Tag> GetTagById(Guid id);
        public Task<Tag> GetTagByName(string name);
        public Task<List<Tag>> GetAllTags();
        public void CreateTag(Tag tag);
        public void UpdateTag(Tag tag);
        public void DeleteTag(Guid id);
    }
}