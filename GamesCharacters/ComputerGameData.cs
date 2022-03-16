using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GamesCharacters
{
    public class ComputerGameData: DbContext
    {
        public ComputerGameData() : base("MyComputerGameData")
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<ComputerGame> ComputerGames { get; set; }
    }
}
