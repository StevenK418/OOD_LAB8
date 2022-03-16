using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lab8_CodeFirst
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int TeamID { get; set; }
        public virtual Team Team { get; set; }
    }
}