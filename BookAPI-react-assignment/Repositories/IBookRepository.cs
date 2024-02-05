using BookAPI_react_assignment.Entities;

namespace BookAPI_react_assignment.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        Book GetBook(string id);
        List<Book> GetAllBooks();
        void UpdateBook(Book book);
        void DeleteBook(string id);


    }
}
