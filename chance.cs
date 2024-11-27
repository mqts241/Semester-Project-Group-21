using System.Dynamic;

namespace WorldOfZuul;

public class Chance
{
    public string PerformedAction {get; private set;}
    public string TheGoodEnding {get; private set;} //Good outcome, e.g. you throw knife and hit your target
    public string TheBadEnding {get; private set;} //You fucking suck

    public Chance(string performedAction, string thebadending, string thegoodending)
    {
        PerformedAction = performedAction;
        TheBadEnding = thebadending;
        TheGoodEnding = thegoodending;
    }


    public void ThrowDice()
    {
        Console.WriteLine(PerformedAction); //initial line describing the action the player performs
        Random random = new();
        int randomNumber = random.Next(1, 3); // Generates a number between 1 and 2
        Console.WriteLine(randomNumber); // This should be removed later -> Only show outcome

        switch (randomNumber) // Differnt scenarios for the action performed (e.g. Ranger throwing his knife)
        {
            case 1:
                Console.WriteLine(TheBadEnding);
                //Bad case: Subract from the over all score (-1 or something)
                break;
            case 2:
                Console.WriteLine(TheGoodEnding);
                //Good case: Add score to the final score (+1 or something)
                break;
        }
    }
}
