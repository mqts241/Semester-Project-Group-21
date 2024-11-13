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
}