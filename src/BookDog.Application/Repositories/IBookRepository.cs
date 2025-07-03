using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    interface IBookRepository
    {
        Task<Book> GetBookById(Guid id);
        Task<List<Book>> GetAllBooks();
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Guid id);
    }
}