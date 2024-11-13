namespace WorldOfZuul;
// THIS PRINTER WILL PRINT OUT OUR TEXT SO THAT IT DOES NOT CLOG THE GAME.CS FILE
public class Printer{
  public static void PrintWelcome()
  {
    Console.WriteLine("\n\n\t\t  ____                  _                      ___     ____           _                ");
    Console.WriteLine("\t\t |  _ \\ ___   __ _  ___| |__   ___ _ __ ___   ( _ )   |  _ \\ ___  ___| |_ ___ _ __ ___ ");
    Console.WriteLine("\t\t | |_) / _ \\ / _` |/ __| '_ \\ / _ \\ '__/ __|  / _ \\/\\ | |_) / _ \\/ __| __/ _ \\ '__/ __|");
    Console.WriteLine("\t\t |  __/ (_) | (_| | (__| | | |  __/ |  \\__ \\ | (_>  < |  __/ (_) \\__ \\ ||  __/ |  \\__ \\");
    Console.WriteLine("\t\t |_|   \\___/ \\__,_|\\___|_| |_|\\___|_|  |___/  \\___/\\/ |_|   \\___/|___/\\__\\___|_|  |___/\n\n\n");
    PrintCmds();
  }
  public static void PrintCmds()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nNavigate by typing 'north', 'south', 'east', or 'west'.");
    Console.WriteLine("> Type 'look' for more details.");
    Console.WriteLine("> Type 'back' to go to the previous room.");
    Console.WriteLine("> Type 'commands' or 'cmds' to give a list of all the commands.");
    Console.WriteLine("> Type 'take' to take an item from an area.");
    Console.WriteLine("> Type 'throw' to place an item in an area.");
    Console.WriteLine("> Type 'give' to give an item to someone.");
    Console.WriteLine("> Type 'inventory' or 'inv' to have a list of the items in your inventory.");
    Console.WriteLine("> Type 'poster' to put up a poster in an area.");
    Console.WriteLine("> Type 'quit' to exit the game.\n");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("(For Debugging) Type 'view' to check the list of items in each room.");
    Console.ResetColor();
  }
  public static void GameOver()
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n\n\t\t   ____    _    __  __ _____     _____     _______ ____  ");
    Console.WriteLine("\t\t  / ___|  / \\  |  \\/  | ____|   / _ \\ \\   / / ____|  _ \\ ");
    Console.WriteLine("\t\t | |  _  / _ \\ | |\\/| |  _|    | | | \\ \\ / /|  _| | |_) |");
    Console.WriteLine("\t\t | |_| |/ ___ \\| |  | | |___   | |_| |\\ V / | |___|  _ < ");
    Console.WriteLine("\t\t  \\____/_/   \\_\\_|  |_|_____|   \\___/  \\_/  |_____|_| \\_\\");
    Console.ResetColor();
  }
  public static void TheEnd()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n\n\t\t  _____ _              _____           _ ");
    Console.WriteLine("\t\t |_   _| |__   ___    | ____|_ __   __| |");
    Console.WriteLine("\t\t   | | | '_ \\ / _ \\   |  _| | '_ \\ / _` |");
    Console.WriteLine("\t\t   | | | | | |  __/   | |___| | | | (_| |");
    Console.WriteLine("\t\t   |_| |_| |_|\\___|   |_____|_| |_|\\__,_|\n\n");
    Console.ResetColor();
  }
  public static void ExitMessage(int Reputation) //THE FINAL THINGS IT PRINTS WHEN TYPING QUIT
  {
    Console.WriteLine("\n\n\t Congratulations, you completed our game. Let's see how well you did!\n\t\t\t[Press 'Enter' to continue]\n\n");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
    switch(Reputation)
    {
      case int n when (n>0 && n<=15):
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"You have a reputation of: {n}. Sadly you did nothing and now those poachers are coming after you next! I'd suggest keep an eye open tonight.");
        break;
      case int n when (n>15 && n<50):
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"You have a reputation of: {n}. Maybe you shouldn't have slapped that gorrila...");
        break;
      case int n when (n>=50 && n<=75):
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"You have a reputation of: {n}. It may not be the best score ever, but it's yours and you should be (somewhat) proud of it. I will still judge you tho.");
        break;
      case int n when (n>75):
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"You have a reputation of: {n}. Great job! You can now become a full time ranger and combat crime in the wildlife :D");
        break;
      default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(">> Why did you even bother running this code? You did nothing. You let those poachers ruin our wildlife.. how could you?..");
        break;
    }
    Console.ResetColor();
  }
}
