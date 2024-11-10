using BasicMVCProject.Models.Entitiy;

namespace BasicMVCProject.Models.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
