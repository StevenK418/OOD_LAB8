using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8_CodeFirst;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamData db = new TeamData();

            using (db)
            {
                //Create some team and player objects
                Team t1 = new Team(){TeamID = 1, TeamName = "Sligo Rovers", Location = "Sligo"};
                Player p1 = new Player(){PlayerID = 1, Name = "Tom", Position = "Forward", TeamID = 1, Team = t1};
                Player p2 = new Player(){ PlayerID =2, Name = "Mick", Position = "Defender", TeamID = 1, Team = t1 };

                Team t2 = new Team(){TeamID = 2, TeamName = "Donegal Rovers", Location = "Donegal" };
                Player p3 = new Player(){PlayerID = 3, Name = "Sam", Position = "Midfielder", TeamID = 2, Team = t2 };
                Player p4 = new Player(){PlayerID = 4, Name = "Joe", Position = "Goalkeeper", TeamID = 2, Team = t2 };

                //Add to database
                db.Teams.Add(t1);
                db.Teams.Add(t2);

                Console.WriteLine("Added teams to DB");

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                //Save the changes
                db.SaveChanges();

                Console.WriteLine("Saving changes to database!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
