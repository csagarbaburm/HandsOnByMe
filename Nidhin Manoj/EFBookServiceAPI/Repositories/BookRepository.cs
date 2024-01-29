using EFBookServiceAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace EFBookServiceAPI.Repositories
{
    public class BookRepository : IBookRepository<Book>
    {
        private readonly Mycontext _context;

        public BookRepository(Mycontext context)
        {
            _context = context;
        }

        public void Add(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Book book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public List<Book> GetByAuthor(string author)
        {
            try
            {
                var books = _context.Books.Where(x => x.Author == author);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Book> GetByLang(string lang)
        {

            try
            {
                var books = _context.Books.Where(x => x.Lang == lang);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Book> GetByYear(int year)
        {

            try
            {
                var books = _context.Books.Where(x => x.ReleaseDate == year);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Update(Book entity)
        {
            try
            {
                _context.Books.Update(entity);
                _context.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
