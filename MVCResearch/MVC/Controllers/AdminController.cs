using System.Collections.Generic;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {

        private readonly List<ProductModel> _products = new List<ProductModel>
        {
            new ProductModel{Id = 1, Name = "Julio Avellaneda",CategoryName = "Food"},
            new ProductModel {Id = 2, Name = "Juan Torres", CategoryName = "Food"},
            new ProductModel {Id = 3, Name = "Oscar Camacho", CategoryName = "Food"},
            new ProductModel {Id = 4, Name = "Gina Urrego", CategoryName = "Water"},
            new ProductModel {Id = 5, Name = "Nathalia Ramirez", CategoryName = "Water"},
            new ProductModel {Id = 6, Name = "Raul Rodriguez", CategoryName = "Food"},
            new ProductModel {Id = 7, Name = "Johana Espitia", CategoryName = "Food"}
        };

        // GET: Admin
        public ActionResult Index()
        {
            return View(_products);
        }
    }
}