using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GamesCharacters
{
    public class Character
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public virtual ComputerGame ComputerGame { get; set; }
    }
}
