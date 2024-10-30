namespace WorldOfZuul;
public class Inventory
{
  public List<Item?> Items { get; set; } = new();
  public const int MaxInventory = 20;  //SET THE MAXIMUM AMMOUNT OF ITEMS THE PLAYER CAN CARRY IN-GAME
}