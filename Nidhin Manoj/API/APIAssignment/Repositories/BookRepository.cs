
using APIAssignment.Model;

namespace APIAssignment.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Book> books = new List<Book>();
        public void Add(Book book)
        {
            try
            {

                books.Add(book);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {

                foreach (var book in books)
                {
                    if (book.BookId == id)
                        books.Remove(book);
                    return;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book GetBooksByName(string name)
        {
            try
            {
                
                foreach (var book in books)
                {
                    if (book.BookName == name)
                      
                    return book;
                }
                return null;

                
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        public List<Book> GetBooksByAuthor(string author)
        {
            try
            {
                List<Book> getbooksbyauthor = new List<Book>();
                foreach (var book in books)
                {
                    if (book.Author == author)
                        getbooksbyauthor.Add(book);

                }
                return getbooksbyauthor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByLanguage(string language)
        {
            try
            {
                List<Book> getbooksbylanguage = new List<Book>();
                foreach (var book in books)
                {
                    if (book.Language == language)
                    {
                        getbooksbylanguage.Add(book);

                    }

                }
                return getbooksbylanguage;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByYear(int year)
        {
            try
            {
                List<Book> getbooksbyyear = new List<Book>();



                foreach (var book in books)
                {
                    if (book.ReleaseYear == year)
                    {
                        getbooksbyyear.Add(book);

                    }

                }
                return getbooksbyyear;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Book book)
        {

            try
            {
                foreach (var item in books)
                {
                    if (item.BookId == book.BookId)
                    {
                        item.BookName = book.BookName;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Book GetBooksById(int id)
        {

            try
            {

                foreach (var book in books)
                {
                    if (book.BookId == id)
                        return book;

                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
