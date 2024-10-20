using Microsoft.AspNetCore.Mvc;
using ViewModelApp.Models;
using ViewModelApp.Models.ViewModel;

namespace ViewModelApp.Controllers
{
    public class FootballerController : Controller
    {
        List<Team> teams = new List<Team>()
        {
            new Team{TeamID=1, TeamName="Galatasaray"},
            new Team{TeamID=2, TeamName="Fenerbahçe"},
            new Team{TeamID=3, TeamName="Beşiktaş"},
            new Team{TeamID=4, TeamName="Trabzonspor"},
            new Team{TeamID=5, TeamName="Bursaspor"},
            new Team{TeamID=6, TeamName="Başakşehir"},
        };

        List<Position> positions = new List<Position>()
        {
            new Position{PositionID=1, PositionName="Goalkeeper"},
            new Position{PositionID=2, PositionName="Defense"},
            new Position{PositionID=3, PositionName="Midfield"},
            new Position{PositionID=4, PositionName="Forward"},
        };

        public IActionResult Index(FootballerAddVM footballerVM)
        {
            return View(footballerVM);
        }

        public IActionResult Create()
        {
            FootballerAddVM footballerAddVM = new FootballerAddVM();
            footballerAddVM.Footballer = new Footballer();
            footballerAddVM.Positions = positions;
            footballerAddVM.Teams = teams;
            return View(footballerAddVM);
        }

        [HttpPost]
		public IActionResult Create(FootballerAddVM footballerAddVM)
		{
            Position position = positions.FirstOrDefault(x => x.PositionID == footballerAddVM.Footballer.PositionID);
            Team team = teams.FirstOrDefault(x => x.TeamID == footballerAddVM.Footballer.TeamID);
			footballerAddVM.Footballer.Position = position;
            footballerAddVM.Footballer.Team = team;
			return View("Index", footballerAddVM); // Futbolcu modelini Index'e gönderiyor 
		}
	}
}
