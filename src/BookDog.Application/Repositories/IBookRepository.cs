using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IBookRepository
    {
        public Task<Book> GetBookById(Guid id);
        public Task<List<Book>> GetAllBooks();
        public void CreateBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(Guid id);
    }
}