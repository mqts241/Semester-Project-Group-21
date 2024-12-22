using System.Dynamic;
using System.Threading; //Adds a delay between Console.WriteLines()

namespace WorldOfZuul;

public class Chance
{
    public string PerformedAction {get; private set;}
    public string TheGoodEnding {get; private set;} //Good outcome, e.g. you throw knife and hit your target
    public string TheBadEnding {get; private set;} //Bad outcome, e.g. you miss your throw

    public Chance(string performedAction, string thebadending, string thegoodending)
    {
        PerformedAction = performedAction;
        TheBadEnding = thebadending;
        TheGoodEnding = thegoodending;
    }


    public void ThrowDice()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(PerformedAction); //initial line describing the action the player performs
        Thread.Sleep(1000);
        for (int i = 0; i<3 ; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); //Delay for 1000ms
        }
        Console.WriteLine("");  //Add an empty line
        Random random = new();
        int randomNumber = random.Next(1, 3); // Generates a number between 1 and 2

        switch (randomNumber) // Differnt scenarios for the action performed (e.g. Ranger throwing his knife)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(TheBadEnding);
                //Bad case: Subract from the over all score (-1 or something)
                Console.ResetColor();
                Thread.Sleep(2000);
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(TheGoodEnding);
                //Good case: Add score to the final score (+1 or something)
                Console.ResetColor();
                Thread.Sleep(2000);
                break;
        }
    }
}
