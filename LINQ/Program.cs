using System.Linq;


namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
            1. Create a list of type string. - DONE
            2. Populate the list with video game names. - DONE
                - Alternatively, you can choose a different category of items if you prefer. ex. list of baseball teams, list of movie titles, etc.
            3. Order the list of games by the length of the game name.
                - Remember to use LINQ which involves using a lambda expression.
                - Use the list of common LINQ methods on the lecture page for help on deciding which method(s) to use: Linq Methods
                - Use Method Syntax for this exercise.
            */
            var myGames = new List<string>
            { "Call of Duty", "Halo", "Destiny 2", "Apex Legends", "Rainbow Six Siege", "Cuphead"};

            var gamesOrdered = myGames.OrderBy(x => x.Length);

            foreach (var game in gamesOrdered)
            {
                Console.WriteLine(game);
            }


            
        }
    }
}
