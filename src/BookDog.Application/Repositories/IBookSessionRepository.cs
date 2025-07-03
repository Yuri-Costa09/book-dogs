using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IBookSessionRepository
    {
        public Task<BookSession> GetBookSessionById(Guid id);
        public Task<List<BookSession>> GetBookSessionsByUserId(Guid userId);
        public Task<List<BookSession>> GetBookSessionsByBookName(string bookName);
        public Task<List<BookSession>> GetBookSessionsByTagName(string tagName);
        public Task<List<BookSession>> GetAllBookSessions();
        
        public void CreateBookSession(BookSession bookSession);
        public void UpdateBookSession(BookSession bookSession);
        public void DeleteBookSession(Guid id);
        
    }
}