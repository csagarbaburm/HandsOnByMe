namespace EFBookServiceAPI.Repositories
{
    public interface IBookRepository<T> where T : class
    {
        
            void Add(T entity);
            List<T> GetAll();
            List<T> GetByAuthor(string author);
            List<T> GetByLang(string lang);

            List<T> GetByYear(int year);
            void Update(T entity);
            void Delete(int id);
      
            
        
    }
}
