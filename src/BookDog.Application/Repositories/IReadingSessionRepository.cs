using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IReadingSessionRepository
    {
        public Task<ReadingSession> GetReadingSessionById(Guid id);
        public Task<List<ReadingSession>> GetAllReadingSessionsByBookSessionId(Guid bookSessionId);
        
        public void CreateReadingSession(ReadingSession readingSession);
        public void UpdateReadingSession(ReadingSession readingSession);
        public void DeleteReadingSession(Guid id);
    }
}