using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesCharacters;

namespace GameDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            ComputerGameData db = new ComputerGameData();

            using (db)
            {

                //Create instances
                ComputerGame cg1 = new ComputerGame(){GameID = 1, Title = "Sonic The Hedgehog", Publisher = "SEGA", Description = "A blue hedgehog collects rings while travelling at subsonic speed", ESRBRating = 7};
                Character ch1 = new Character(){CharacterID = 1, Name = "Sonic", Species = "Hedgehog", Color = "Blue", GameID = 1, ComputerGame = cg1};
                Character ch2 = new Character(){CharacterID = 2, Name = "Tails", Species = "Fox", Color = "Yellow", GameID = 1, ComputerGame = cg1 };

                ComputerGame cg2 = new ComputerGame() { GameID = 2, Title = "Super Mario", Publisher = "Nintendo", Description = "An Italian plumber goes on a rampage across the mushroom kingdom", ESRBRating = 3 };
                Character ch3 = new Character(){CharacterID = 3, Name = "Mario", Species = "Human", Color = "Red", GameID = 2, ComputerGame = cg2 };
                Character ch4 = new Character(){CharacterID = 4, Name = "Luigi", Species = "Human", Color = "Green", GameID = 2, ComputerGame = cg2 };

                //Add the computer games to the database
                db.ComputerGames.Add(cg1);
                db.ComputerGames.Add(cg2);

                Console.WriteLine("Added Games to DB");

                //Add the characters to the database
                db.Characters.Add(ch1);
                db.Characters.Add(ch2);
                db.Characters.Add(ch3);
                db.Characters.Add(ch4);

                //Save the changes
                db.SaveChanges();

                Console.WriteLine("Saving changes to database!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
