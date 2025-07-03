using BookDog.Domain.Entities;

namespace BookDog.Application.Services.Interfaces
{
    public interface IBookSessionService
    {
        List<BookSession> GetBookSessionsByUserId(Guid userId);
        List<BookSession> GetBookSessionsByBookName(string bookName);
        List<BookSession> GetBookSessionsByTagName(string tagName);
        List<BookSession> GetAllBookSessions();
        
        BookSession GetBookSessionById(Guid id);
        
        void LikeBookSession(Guid bookSessionId, Guid userId);
        void CreateBookSession(BookSession bookSession);
        void UpdateBookSession(BookSession bookSession);
        void DeleteBookSession(Guid id);
    }
}