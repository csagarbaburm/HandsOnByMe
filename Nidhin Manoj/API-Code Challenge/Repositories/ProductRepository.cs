using API_Code_Challenge.Model;

namespace API_Code_Challenge.Repositories
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products= new List<Product>();
        public void Add(Product product)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int ProductId)
        {
            try
            {
                foreach (Product product in products)
                {
                    if (product.ProductId.Equals(ProductId))
                        products.Remove(product);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString);
            }
        }

        public Product GetProductByCategory(string Category)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetProductByName(string ProductName)
        {
            try
            {
               
            }

            
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Product product)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
