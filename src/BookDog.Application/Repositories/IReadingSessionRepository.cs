using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    interface IReadingSessionRepository
    {
        Task<ReadingSession> GetReadingSessionById(Guid id);
        Task<List<ReadingSession>> GetAllReadingSessionsByBookSessionId(Guid bookSessionId);
        
        void CreateReadingSession(ReadingSession readingSession);
        void UpdateReadingSession(ReadingSession readingSession);
        void DeleteReadingSession(Guid id);
    }
}