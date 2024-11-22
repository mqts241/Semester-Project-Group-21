
Console.WriteLine("You are throwing your knife!"); //initial line describing the action the player performs
Random random = new();
int randomNumber = random.Next(1, 3); // Generates a number between 1 and 2
Console.WriteLine(randomNumber); // This should be removed later -> Only show outcome

switch (randomNumber) // Differnt scenarios for the action performed (e.g. Ranger throwing his knife)
{
    case 1:
        Console.WriteLine("Oh no, your knife missed the hive and now you need to get it. You search for it, but when you find the poachers already have the lion captured and drive off. You did poorly!");
        //Subract from the over all score (-1 or something)
        break;
    case 2:
        Console.WriteLine("You do a good throw and the knife hits the beehive. It drops right next to the poachers. They run away in fear, meanwhile you free the lion cub.");
        //Add score to the final score (+1 or something)
        break;
}