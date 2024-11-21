namespace WorldOfZuul;

    public class Room
    {
        public string ShortDescription { get; private set; }
        public string LongDescription { get; private set;}
        public Region Area {get; private set;} = new();
        public Dictionary<string, Room> Exits { get; private set; } = new();
        private List<Item> RoomItems { get; set; } = new(); 
        private List<NPC> RoomNPC { get; set; } = new();

        public Room(string shortDesc, string longDesc, string? region = null)
        {
            ShortDescription = shortDesc;
            LongDescription = longDesc;
            Area.Name=region;
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
                Console.WriteLine($"{ShortDescription} has {RoomItems.Count} items:");
                foreach(Item item in RoomItems)
                    Console.WriteLine($"-> {item.Name}");
            }
            else Console.WriteLine("There are no items in the room!");
            Console.ResetColor();
        }
        public void AddNPC(NPC NPC)
        {
            RoomNPC.Add(NPC);
        }
    }


