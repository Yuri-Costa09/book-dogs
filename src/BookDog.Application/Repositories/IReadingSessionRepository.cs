using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IReadingSessionRepository
    {
        Task<ReadingSession> GetReadingSessionById(Guid id);
        Task<List<ReadingSession>> GetAllReadingSessionsByBookSessionId(Guid bookSessionId);
        
        Task CreateReadingSession(ReadingSession readingSession);
        Task UpdateReadingSession(ReadingSession readingSession);
        Task DeleteReadingSession(Guid id);
    }
}