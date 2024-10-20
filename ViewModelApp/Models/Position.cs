namespace ViewModelApp.Models
{
    public class Position
    {
        public int PositionID { get; set; }
        public string PositionName { get; set; }

        // relation için olabilir:
        public ICollection<Footballer> Footballers { get; set; }
    }
}
