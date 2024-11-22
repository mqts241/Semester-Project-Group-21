namespace WorldOfZuul;
public class Item
{
  public string? Name { get; set; }
  private string? Description { get; set; }
  public Item(string name, string description)
  {
      Name=name;
      Description=description;
  }
  public void PrintDescription(){
    Console.WriteLine(Description);
  }
}