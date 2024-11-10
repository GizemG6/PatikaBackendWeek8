using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Models.ViewModel
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }

    }
}
