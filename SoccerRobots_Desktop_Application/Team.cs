using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerRobots_Desktop_Application
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Team team &&
                   Id == team.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode()+Name.GetHashCode()+Color.GetHashCode();
        }
    }
}
