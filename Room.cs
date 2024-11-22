namespace WorldOfZuul;

    public class Room
    {
        public string ShortDescription { get; private set; }
        private string LongDescription { get; set;}
        private Region? Region { get; set; }
        public Dictionary<string, Room> Exits { get; private set; } = new();
        private List<Item> RoomItems { get; set; } = new(); 
        public NPC RoomNPC { get; set; }

        
        private Choice? RoomChoice { get; set; }
        public Room(string shortDesc, string longDesc, string? region = null)
        {
            ShortDescription = shortDesc;
            LongDescription = longDesc;
        }
        public void SetRoomRegion(Region reg){
            Region = reg;
        }
        public void PrintDescription(){
            Console.WriteLine(LongDescription);
        }
        public Region FindRegion(){
            return Region;
        }  
        public void SetExits(Room? north, Room? east, Room? south, Room? west)
        {
            SetExit("north", north);
            SetExit("east", east);
            SetExit("south", south);
            SetExit("west", west);
        }
        public void SetExit(string direction, Room? neighbor)
        {
            if (neighbor != null)
                Exits[direction] = neighbor;
        }
        public Choice roomChoice()
        {
            return RoomChoice; 
        }
        public void SetterChoice(Choice setter)
        {
            RoomChoice = setter;
        }
        public void AddItem(Item item)
        {
            RoomItems.Add(item);
        }
        public void RemoveItem(Item item)
        {
            RoomItems.Remove(item);
        }
        public bool IsEmpty()
        {
            if(RoomItems.Count == 0)
                return true;
            return false;
        }
        public Item FindItemInRoom(string b)
        {
            foreach(Item? item in RoomItems)
            {
                if(item.Name.Equals(b, StringComparison.CurrentCultureIgnoreCase))
                    return item;
            }
            return null;
        }
        public void View()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if(IsEmpty() == false)
            {
                Console.Write($"You look around and discover that {ShortDescription} has {RoomItems.Count} interesting items such as");
                foreach(Item item in RoomItems)
                    Console.Write($" {item.Name}");
            }
            else Console.WriteLine("There are no items in the room!");
            Console.ResetColor();
        }
        public void SetChoice(Choice choice)
        {
            RoomChoice = choice;
        }
        
    }


