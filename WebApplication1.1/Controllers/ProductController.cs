using Microsoft.AspNetCore.Mvc;
using WebApplication1._1.Models;

namespace WebApplication1._1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productrepository;


        public ProductController(IProductRepository productrepository)
        {
            _productrepository = productrepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = _productrepository.GetAllProducts();
            return View(products);
        }
    }
}
