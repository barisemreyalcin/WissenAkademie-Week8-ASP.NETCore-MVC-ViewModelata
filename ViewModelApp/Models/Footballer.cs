namespace ViewModelApp.Models
{
    public class Footballer
    {
        public int FootballerID { get; set; } 
        public string FullName { get; set; }
        public int Age { get; set; }
        public int PositionID { get; set; }
        public int TeamID { get; set; }
        public Position Position { get; set; }
        public Team Team { get; set; }
    }
}
