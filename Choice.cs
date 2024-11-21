using System.Xml.Serialization;
namespace WorldOfZuul;

public class Choice
{
    public string Question{ get; }
    public List<string> Options{ get; }
    public Dictionary<int, string> Results { get; }

    public Choice(string question, List<string> options, Dictionary<int, string> results)
    {
        Question = question;
        Options = options;
        Results = results;

        //Ensures that options and result have the same amount 
        if(Options.Count != Results.Count)
        {
            throw new ArgumentException("Options and results must have the same number of items.");
        }
    }

    public int MakeChoice()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(Question);

        //Display the options
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }

        Console.WriteLine("Enter the Number of your choice: ");
        Console.ResetColor();
        Console.Write("> ");

        int choice;
        // Try to parse the input and check if the choice is in the valid range of choices
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Options.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This choice is not a valid option! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the Number of your choice: ");
            Console.ResetColor();
            Console.Write("> ");
        }
        return choice;
    }
    
    public string GetResult(int choiceIndex)
    {
        return Results[choiceIndex];
    }
}