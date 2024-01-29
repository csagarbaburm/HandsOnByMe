using API_Code_Challenge.Model;

namespace API_Code_Challenge.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        Product GetProductByName(string ProductName);
        Product GetProductByCategory(string Category);



    }
}
