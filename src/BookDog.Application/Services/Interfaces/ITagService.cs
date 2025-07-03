namespace BookDog.Application.Services.Interfaces
{
    public interface ITagService
    {
        void CreateTag(string name);
        void UpdateTag(Guid tagId, string name);
        void DeleteTag(Guid tagId);
    }
}