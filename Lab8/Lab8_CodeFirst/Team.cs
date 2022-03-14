using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_CodeFirst
{
    class Team
    {

        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }
        public virtual List<Player> Players { get; set; }
        
    }
}
