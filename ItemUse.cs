namespace WorldOfZuul;

public class ItemUse(Room room)
{
    private readonly Room currentRoom = room;

    //To know if an item can be used in the current room
    public bool CanUseItem(Item item)
    {
        //EXPAND THIS 
        //Which ITEMS can be USABLE and WHERE
        //DEFINITION:  if(currentRoom.ShortDescription == "Room_Name" && item.Name == "Item_Name")
        if(currentRoom.ShortDescription == "Lion" && item.Name == "Knife") {return true;}
        if(currentRoom.ShortDescription == "Action" && item.Name == "Flare_gun") {return true;}
        if(currentRoom.ShortDescription == "Waterhole" && item.Name == "Antidote") {return true;}
        if(currentRoom.ShortDescription == "Water" && item.Name == "Cleanser") {return true;}

        //USE ROOM  -  Gorilla. The Trap / The Hideout
        if(currentRoom.ShortDescription == "The Trap" && item.Name == "Tranquilizer") {return true;}
        if(currentRoom.ShortDescription == "The Hideout" && item.Name == "Tranquilizer") {return true;}
        if(currentRoom.ShortDescription == "The Trap" && item.Name == "Medkit") {return true;}
        if(currentRoom.ShortDescription == "The Trap" && item.Name == "Banana") {return true;}
        if(currentRoom.ShortDescription == "The Hideout" && item.Name == "Banana") {return true;}
        return false; //If the item cannot be used in this room
    }
    //To define the output after using an item in the right room
    public void UseItemResult(Item item)
    {
        if(item.Name == "Knife" && currentRoom.ShortDescription == "Lion")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You free the cub from the snare trap. Good job!");
            
            Console.ResetColor();
            //Add any Aditional actions that will occur when Item1 is used
        }
        if(item.Name == "apple" && currentRoom.ShortDescription == "Rhino Village")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The rhino accepts the apple and calms down. He will no longer be a danger to humans");
            
            Console.ResetColor();
            //Add any Aditional actions that will occur when Item1 is used
        }
        if(item.Name == "Flare_gun" && currentRoom.ShortDescription == "Action")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You take the flare gun out of your pocket and aim it into the sky.\nWith a loud bang you shoot the flare into the sky. It explodes with another loud bang.\nThe poachers, seemingly scared and shocked by the noise, flee into the wilderness.\nBut just after the poachers went into a different direction, you notice the herd of zebras scattering apart.\nThey are in even more panic than before, some of them disoriented, not knowing where to go.\nYou now are in the thought that your actions, even though you scared off the poachers, made the zebras even more traumatized than they were before.");
            
            Console.ResetColor();
        }
        if(item.Name == "Antidote" && currentRoom.ShortDescription == "Waterhole")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You take out the chest you found earlier and take out the antidote.\nAfter infusing the antidote to the elephant, the elephant stabilized.\nYou still must find the reason for the poisoning. \nYou should examine the water in the waterhole to the north.");
            
            Console.ResetColor();
        }
        if(item.Name == "Cleanser" && currentRoom.ShortDescription == "Water")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Using the neutralizer from the chest, you cleanse the water, ensuring that no other animals will fall victim.");
            
            Console.ResetColor();

        //USE RESULT  -  Gorilla. the Trap / The Hideout
        if(item.Name == "Tranquilizer" && currentRoom.ShortDescription == "The Trap")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You shoot at the Alpha to put him to sleep, but the Gorillas interpret it as a threat, harming you in the process and loosing their respect");
            Console.ResetColor();
        }

        if(item.Name == "Medkit" && currentRoom.ShortDescription == "The Trap")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You heal the injuries of the Alpha gorilla, this made him to trust you, and before you leave he signs the east side of the sanctuary, as if there is something going on there that requires your attention. ");
            Console.ResetColor();
            
        }

        if(item.Name == "Banana" && currentRoom.ShortDescription == "The Trap")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You feed the Alpha Gorilla, giving him confidence");
            Console.ResetColor();
            
        }
        if(item.Name == "Banana" && currentRoom.ShortDescription == "The Hideout")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You throw a banana to the Poachers head, nothing happens");
            Console.ResetColor();
            
        }

        if(item.Name == "Tranquilizer" && currentRoom.ShortDescription == "The Hideout")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You aim at the poacher and shoot a tranq, succesfully sleeping the driver, the copilot is now in panic, and he runs away to the folliage, the gorillas are safe. Good Job!");
            Console.ResetColor();
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You notice a man with a ranger uniform coming out of the east, he is calling you to come, is that Julian?");
            Console.ResetColor();

        }
        else
        {
            Console.WriteLine("This item was used succesfully");
        }
    }}

    public static implicit operator ItemUse(Item v)
    {
        throw new NotImplementedException();
    }
}

