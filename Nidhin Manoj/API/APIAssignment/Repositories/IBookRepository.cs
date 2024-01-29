using APIAssignment.Model;

namespace APIAssignment.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        List<Book> GetAllBooks();
        List<Book> GetBooksByAuthor(string author);
        Book GetBooksByName(string name);
        Book GetBooksById(int id);
        List<Book> GetBooksByLanguage(string language);
        List<Book> GetBooksByYear(int year);
        void Update(Book book);
        void Delete(int id);
      
    }
}
