namespace ViewModelApp.Models.ViewModel
{
    public class ProductAddVM
    {
        public Product Product { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }
    }
}
