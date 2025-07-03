using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    interface IBookSessionRepository
    {
        Task<BookSession> GetBookSessionById(Guid id);
        Task<List<BookSession>> GetBookSessionsByUserId(Guid userId);
        Task<List<BookSession>> GetBookSessionsByBookName(string bookName);
        Task<List<BookSession>> GetBookSessionsByTagName(string tagName);
        Task<List<BookSession>> GetAllBookSessions();
        
        void CreateBookSession(BookSession bookSession);
        void UpdateBookSession(BookSession bookSession);
        void DeleteBookSession(Guid id);
        
    }
}