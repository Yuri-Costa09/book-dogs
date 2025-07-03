using BookDog.Domain.Entities;

namespace BookDog.Application.Services.Interfaces
{
    public interface IReadingSessionService
    {
        ReadingSession GetReadingSessionById(Guid id);
        List<ReadingSession> GetAllReadingSessionsByBookSessionId(Guid bookSessionId);
        void CreateReadingSession(ReadingSession readingSession);
        void UpdateContent(Guid id, string content);
        void UpdateTitle(Guid id, string title);
        void DeleteReadingSession(Guid id);
    }
}