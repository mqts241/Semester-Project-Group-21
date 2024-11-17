
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
        if(currentRoom.ShortDescription == "The Operations Center" && item.Name == "Item1") {return true;} //Item1 can be used in the Grassland
        if(currentRoom.ShortDescription == "The Operations Center" && item.Name == "Item2") {return true;}
        if(currentRoom.ShortDescription == "The Operations Center" && item.Name == "Item3") {return true;}
        return false; //If the item cannot be used in this room
    }
    //To define the output after using an item in the right room
    public void UseItemResult(Item item)
    {
        if(item.Name == "Item1" && currentRoom.ShortDescription == "The Operations Center")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GG, Item1 works");
            Console.ResetColor();
            //Add any Aditional actions that will occur when Item1 is used
        }
        if(item.Name == "Item2" && currentRoom.ShortDescription == "The Operations Center")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GG, Item2 works");
            Console.ResetColor();
            //Add any Aditional actions that will occur when Item1 is used
        }
        if(item.Name == "Item3" && currentRoom.ShortDescription == "The Operations Center")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GG, Item3 works");
            Console.ResetColor();
            //Add any Aditional actions that will occur when Item1 is used
        }

        else
        {
            Console.WriteLine("This item was used succesfully");
        }
    }

    public static implicit operator ItemUse(Item v)
    {
        throw new NotImplementedException();
    }
}

