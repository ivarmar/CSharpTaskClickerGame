namespace CSharpTaskClickerGame
{
    internal class Program
    {
        private static void Main()
        {

            var game = new ClickerGame();
            var commandSet = new CommandSet(game);
            while (true)
            {
                Console.Clear();

                Console.WriteLine("As you click you'll see your points");
                Console.WriteLine("Press 'space' to get points per click");
                Console.WriteLine("'k' to upgrade points per click.(requires 10 points)");
                Console.WriteLine("'s' for Super Upgrade!(requires 100 points)");
                Console.WriteLine($"You have {game.Points} Points");
                var key = Console.ReadKey().KeyChar;

                commandSet.RunCommand(key);
            }
        }
    }
}

/*        int points = 0;
int pointsPerClick = 1;
int pointsPerClickIncrease = 1;

while (true)
{
    Console.Clear();
    Console.WriteLine("Kommandoer:\r\n
                      - SPACE = klikk(og få poeng)\r\n
                                                     - K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n
        - S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n
                                           - X = avslutt applikasjonen");
    Console.WriteLine($"Du har {points} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");
    var command = Console.ReadKey().KeyChar;
    if (command == 'X') Environment.Exit(0);
    else if (command == ' ') points += pointsPerClick;
    else if (command == 'K' && points >= 10)
    {
        points -= 10;
        pointsPerClick += pointsPerClickIncrease;
    }
    else if (command == 'S' && points >= 100)
    {
        points -= 100;
        pointsPerClickIncrease++;
    }
}
}
*/
