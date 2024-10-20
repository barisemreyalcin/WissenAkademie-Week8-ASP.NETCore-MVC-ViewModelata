namespace ViewModelApp.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Coach { get; set; }

        // relation için olabilir:
        public ICollection<Footballer> Footballers { get; set; }
    }
}
