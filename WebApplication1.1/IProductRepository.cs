using WebApplication1._1.Models;

namespace WebApplication1._1
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}