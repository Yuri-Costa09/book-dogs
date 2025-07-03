using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IBookSessionRepository
    {
        Task<BookSession> GetBookSessionById(Guid id);
        Task<List<BookSession>> GetBookSessionsByUserId(Guid userId);
        Task<List<BookSession>> GetBookSessionsByBookName(string bookName);
        Task<List<BookSession>> GetBookSessionsByTagName(string tagName);
        Task<List<BookSession>> GetAllBookSessions();
        
        Task CreateBookSession(BookSession bookSession);
        Task UpdateBookSession(BookSession bookSession);
        Task DeleteBookSession(Guid id);
        
    }
}