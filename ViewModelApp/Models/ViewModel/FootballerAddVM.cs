namespace ViewModelApp.Models.ViewModel
{
    public class FootballerAddVM
    {
        public Footballer Footballer { get; set; }
        public List<Position> Positions { get; set; } // Burdan mevki seçilebilecek
        public List<Team> Teams { get; set; } // Burdan takım seçilebilecek
    }
}
