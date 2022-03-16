using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace Lab8_CodeFirst
{
    public class Team
    {

        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }
        public string HomeGround { get; set; }
        public virtual List<Player> Players { get; set; }
        
    }
}
