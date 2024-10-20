using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using ViewModelApp.Models;
using ViewModelApp.Models.ViewModel;

namespace ViewModelApp.Controllers
{
    public class ProductController : Controller
    {
        List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier{SupplierID = 1, CompanyName = "Exotic Liquids", ContactName= "Charlotte Cooper", ContactTitle="Purchasing Manager", Address="49 Gilbert St.", City= "London", Country="UK", Phone="(171) 555-2222"},
            new Supplier{SupplierID = 2, CompanyName = "New Orleans Cajun Delights", ContactName= "Shelley Burke", ContactTitle="Order Administrator", Address="P.O. Box 78934", City= "New Orleans", Country="USA", Phone="(100) 555-4822"},
            new Supplier{SupplierID = 3, CompanyName = "Grandma Kelly's Homestead", ContactName= "Regina Murphy", ContactTitle="Sales Representative", Address="707 Oxford Rd.", City= "Ann Arbor", Country="USA", Phone="(313) 555-5735"},
            new Supplier{SupplierID = 4, CompanyName = "Tokyo Traders", ContactName= "Yoshi Nagase", ContactTitle="Marketing Manager", Address="9-8 Sekimai Musashino-shi", City= "Tokyo", Country="Japan", Phone="(03) 3555-5011"}
        };

        List<Category> categories = new List<Category>()
        {
            new Category{CategoryID =1, CategoryName="Beverages",Description="Soft drinks, coffees, teas, beers, and ales"},
            new Category{CategoryID =2, CategoryName="Condiments",Description="Sweet and savory sauces, relishes, spreads, and seasonings"},
            new Category{CategoryID =3, CategoryName="Confections",Description="Desserts, candies, and sweet breads"},
            new Category{CategoryID =4, CategoryName="Dairy Products",Description="Cheeses"},
            new Category{CategoryID =5, CategoryName="Grains/Cereals",Description="Breads, crackers, pasta, and cereal"},
            new Category{CategoryID =6, CategoryName="Meat/Poultry",Description="Prepared meats"},
            new Category{CategoryID =7, CategoryName="Produce",Description="Dried fruit and bean curd"},
            new Category{CategoryID =8, CategoryName="Seafood",Description="Seaweed and fish"},
        };

        public IActionResult Index(ProductAddVM productVM)
        {
            return View(productVM);
        }

        public IActionResult Create()
        {
            ProductAddVM productAddVM = new ProductAddVM();
            productAddVM.Product = new Product();
            productAddVM.Suppliers = suppliers;
            productAddVM.Categories = categories;

            return View(productAddVM);
        }

        [HttpPost]
        public IActionResult Create(ProductAddVM productAddVM)
        {
            Supplier supplier = suppliers.FirstOrDefault(x => x.SupplierID == productAddVM.Product.SupplierID);
            Category category = categories.FirstOrDefault(x => x.CategoryID == productAddVM.Product.CategoryID);
            productAddVM.Product.Supplier = supplier;
            productAddVM.Product.Category = category;
            return View("Index", productAddVM); // Futbolcu modelini Index'e gönderiyor 
        }
    }
}
