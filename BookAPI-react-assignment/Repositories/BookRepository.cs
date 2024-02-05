using BookAPI_react_assignment.Entities;

namespace BookAPI_react_assignment.Repositories
{
    public class BookRepository:IBookRepository
    {
        public MyContext myContext;

        public BookRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public void AddBook(Book book)
        {
            myContext.Books.Add(book);
            myContext.SaveChanges();
        }

        public void DeleteBook(string id)
        {
            Book book = myContext.Books.Find(id);
            myContext.Books.Remove(book);
            myContext.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return myContext.Books.ToList();
        }

        public Book GetBook(string id)
        {
            return myContext.Books.Find(id);
        }

        public void UpdateBook(Book book)
        {
            myContext.Update(book);
            myContext.SaveChanges();
        }
    }
}
