using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerRobots_Desktop_Application
{
    public class Match
    {
        public int Id { get; set; }
        public int IdTeamA { get; set; }
        public int IdTeamB { get; set; }
        public int IdFootPitch { get; set; }
        public DateTime StartTime { get; set; }
        public int? NbGoalsTeamA { get; set; }
        public int? NbGoalsTeamB { get; set; }
        public string State { get; set; }
    }
}
