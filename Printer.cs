using System.Transactions;

namespace WorldOfZuul;
// THIS PRINTER WILL PRINT OUT OUR TEXT SO THAT IT DOES NOT CLOG THE GAME.CS FILE
public class Printer{
  public static void PrintWelcome()
  {
    Console.Clear();
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
    Console.WriteLine("> Type 'use' to use a specific item in an area.");
    Console.WriteLine("> Type 'inventory' or 'inv' to have a list of the items in your inventory.");
    Console.WriteLine("> Type 'poster' to put up a poster in an area.");
    Console.WriteLine("> Type 'quit' to exit the game.\n");
    Console.WriteLine("> Type 'view' to check the list of items in each room.");
    Console.WriteLine("> Type 'chance' to try your luck.");
    Console.WriteLine("> Type 'talk' to interact with NPCs.");
    Console.ResetColor();
  }
  public static void GameOver()
  {
    Console.Clear();
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
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n\n\t\t  _____ _              _____           _ ");
    Console.WriteLine("\t\t |_   _| |__   ___    | ____|_ __   __| |");
    Console.WriteLine("\t\t   | | | '_ \\ / _ \\   |  _| | '_ \\ / _` |");
    Console.WriteLine("\t\t   | | | | | |  __/   | |___| | | | (_| |");
    Console.WriteLine("\t\t   |_| |_| |_|\\___|   |_____|_| |_|\\__,_|\n\n");
    Console.ResetColor();
  }
  public static void StartQuiz() {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n\t\t\t\t ============ Credits ============\n\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n\t\t\t\t ------ Mihnea Stefan Tudor ------\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\t\t\t\t ---- Kamal Erouais Abdelkader ---\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n\t\t\t\t ---- Cristian Alin Ciacareanu ---\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\n\t\t\t\t ---------- Bo Wiechmann ---------\n");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n\t\t\t\t ---------- Mats Haertel ---------\n");
    Console.ResetColor();
    Console.WriteLine("\n\t\t\t\t Press 'Enter' to start the Quiz.\n");
    Console.ReadKey();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Please, answer to the following statements in relation to the game.");
    Console.ResetColor();
    Quiz quiz = new Quiz();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    quiz.AddQuestion(new Question("\n I. Would you define this game experience as educative?\n"));
    quiz.AddQuestion(new Question("\n II. I understand the role local communities play in combating poaching\n"));
    quiz.AddQuestion(new Question("\n III. I can identify at least seven species that are commonly targeted by poachers.\n"));
    quiz.AddQuestion(new Question("\n IV. I recognize the importance of wildlife conservation efforts in protecting endangered species.\n"));
    quiz.AddQuestion(new Question("\n V. I feel more empowered to take action or spread awareness about anti-poaching efforts.\n"));
    quiz.AddQuestion(new Question("\n VI. I understand how the illegal wildlife trade contributes to global environmental and security issues.\n"));
    quiz.AddQuestion(new Question("\n VII. I can explain the connection between poaching and its effects on local economies.\n"));
    quiz.AddQuestion(new Question("\n VIII. I am familiar with the laws and penalties in place to deter poaching.\n"));
    quiz.AddQuestion(new Question("\n IX. I recognize the significance of supporting Governmental or Non-Governmental measures and support for anti-poaching organizations.\n"));
    quiz.AddQuestion(new Question("\n X. I believe that education and awareness are key to reducing poaching activities worldwide.\n"));
    Console.ResetColor();
    
    var answers = quiz.RunQuiz();

    QuizFileExporter exporter = new QuizFileExporter();
    exporter.ExportAnswers("quiz_results.txt", answers);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n\t Your answers have been stored in a new text file inside the Poachers & Posters folder, please share it with us trough the following email:");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\t\t\t\t\t\t\t\t kaero24@student.sdu.dk");
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
