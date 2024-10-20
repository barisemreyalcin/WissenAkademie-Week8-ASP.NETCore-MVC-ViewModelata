using Microsoft.AspNetCore.Mvc;
using ViewModelApp.Models;

namespace ViewModelApp.Controllers
{
	public class StudentController : Controller
	{
		List<Gender> genders = new List<Gender>()
		{
			new Gender {GenderID = 1, GenderName = "Male"},
			new Gender {GenderID = 2, GenderName = "Female"},
		};

		List<Country> countries = new List<Country>()
		{
			new Country {CountryID = 1, CountryName = "Turkey"},
			new Country {CountryID = 2, CountryName = "USA"},
			new Country {CountryID = 2, CountryName = "UK"},
		};

		public IActionResult Index()
		{
			ViewData["Gender"] = genders;
			ViewData["Country"] = countries;

			// Buraya boş bir Student model gönderelim
			Student student = new Student();
			return View(student);
		}
	}
}
