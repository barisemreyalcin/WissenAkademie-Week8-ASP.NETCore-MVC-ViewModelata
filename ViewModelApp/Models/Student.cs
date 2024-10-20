using System.Reflection;

namespace ViewModelApp.Models
{
	public class Student
	{
		public int StudentID {  get; set; }
		public string FirstName {  get; set; }
		public string LastName {  get; set; }
		public string StudentNumber {  get; set; }
		public Gender Gender { get; set; } // Ara tablom (relation olacak)
		public int GenderID { get; set; }
		public string Address { get; set; }
		public Country Country { get; set; } // Ara tablom (relation olacak)
		public int CountryID { get; set; }
	}
}
