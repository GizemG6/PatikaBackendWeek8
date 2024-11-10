using BasicMVCProject.Models;
using BasicMVCProject.Models.Entitiy;
using BasicMVCProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // new customer object
            var customer = new Customer()
            {
                Id = 1,
                FirstName = "Gizem",
                LastName = "Güneş",
                Email = "0.gizemgunes@gmail.com"
            };

            // new orders list
            var orders = new List<Order>()
            {
                new Order { Id = 1, ProductName = "iPhone 15 Pro Max 512 GB", Price = 87.999M, Quantity = 2 },
                new Order { Id = 2, ProductName = "Apple Macbook Pro M3 Max", Price = 138.899M, Quantity = 1 },
                new Order { Id = 3, ProductName = "JBL Tour One M2", Price = 10.679M, Quantity = 1 }
            };

            // create Custo
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}
