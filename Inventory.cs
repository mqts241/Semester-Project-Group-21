namespace WorldOfZuul;
public class Inventory
{
  private List<Item?> Items { get; set; } = new();
  private const int MaxInventory = 20;  //SET THE MAXIMUM AMMOUNT OF ITEMS THE PLAYER CAN CARRY IN-GAME
  public void SeeInventory(){
    if(Items.Count == 0){
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Your inventory is empty!");
      Console.ResetColor();
    }
    Console.WriteLine("You have in your inventory: ");
    for(int i=0; i < Items.Count; i++)
      Console.WriteLine(" -> " + Items[i]?.Name);
    Console.WriteLine("You have used " + Items.Count + "/" + MaxInventory + " spaces");
    if(Items.Count == MaxInventory){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You have reachead the maximum ammount of storage in your inventory!\n Please use 'throw' in order to free up your space!");
      Console.ResetColor();
    }
  }
  public bool IsFull(){
    if(Items.Count == MaxInventory){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You cannot take anymore items, because you have reachead the maximum ammount of storage in your inventory!\nPlease use 'throw' in order to free up your space!");
      Console.ResetColor();
      return true;
    }
    return false;
  }
  public bool IsEmpty(){
    if(Items.Count == 0)
      return true;
    return false;
  }
  public void AddItem(Item item){
    Items.Add(item);
  }
  public void RemoveItem(Item item){
    Items.Remove(item);
  }
  public Item FindItemInInv(string b){
    foreach(Item? item in Items)
      if(item!.Name!.Equals(b, StringComparison.CurrentCultureIgnoreCase))
        return item;
    return null!;
  }
  public void Take(Room? currentRoom, string b){
    if(currentRoom?.IsEmpty() == false){
      if(!IsFull()){
        Item? a = currentRoom?.FindItemInRoom(b);
        if(a != null){
          Console.WriteLine($"You took {a.Name}");
          AddItem(a);
          currentRoom?.RemoveItem(a);
        }
        else{
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"There isn't an item called {b} in this area.");
          Console.ResetColor();
        }
      }
    }
    else Console.WriteLine("There are no items to take in this area!");
  }
  public void Throw(Room? currentRoom, string b){
    if(IsEmpty() == false){
      Item? a = FindItemInInv(b);
      if(a != null){
        Console.WriteLine($"You put down {a.Name} in {currentRoom?.ShortDescription}");
        RemoveItem(a);
        currentRoom?.AddItem(a);
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"You dont have {b} in your inventory.");
        Console.ResetColor();
      }
    }
    else{
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You can't throw something when you have nothing!");
      Console.ResetColor();
    }
  }

  public void Use(Room currentRoom)
  {
    //The inventory must not be empty
    if(IsEmpty() == true){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You cannot use what you dont have.");
      Console.ResetColor();
      return;
    }

    //Loop until Item is either used correctly or cancelled
    bool usedItem = false;
    while(!usedItem){
      
      //USE List
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("What item do you want to use?");
      Console.ResetColor();
      for(int i = 0; i < Items.Count; i++){ 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i+1}.{Items[i]?.Name}");  //DEFINITION: {Number (starting from 1)}. {Item's name}
        Console.ResetColor();
      }
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("x. Cancel");
      Console.ResetColor();

      //Players Input
      string? selection = Console.ReadLine();

      //Cancel Use Command
      if(selection == "x"){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Item selection Cancelled");
        Console.ResetColor();
        return;
      }

      //Parse to check the validity of the input
      if(int.TryParse(selection, out int selectedIndex)){//It checks if the input can be converted into a integer, basically a valid number

        if(selectedIndex >= 1 && selectedIndex <= Items.Count){ //it tests the input to see if its in the range of use-list inventory
          Item? selectedItem = Items[selectedIndex - 1]; //Retake item  from players inventory
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.WriteLine($"You use {selectedItem?.Name}"); //Shows the name of the selected item
          Console.ResetColor();
          ItemUse itemUse = new(currentRoom);

          if(itemUse.CanUseItem(selectedItem!)){
            itemUse.UseItemResult(selectedItem!);
            usedItem = true; //exits loop
          }
          else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cant use this item here!");
            Console.ResetColor();
          }
        }

        else{
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Invalid selection, please select an item by typing the Index number only.");
          Console.ResetColor();
        }

      }

      else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter an Index number or x to cancel.");
        Console.ResetColor();
      }
    }
  }
}
