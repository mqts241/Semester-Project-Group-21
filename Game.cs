namespace WorldOfZuul
{
    public class Game
    {
        private Room? currentRoom;
        private Room? previousRoom;

        public Game()
        {
            CreateRooms();
        }

        private void CreateRooms()
        {
            // This is where you add rooms
            Room? village_mainroad = new("Village", "You enter a small village, the hum of the daily life around you. You are currently on the main road. In the south you see the market, in the east you see the savannah opening behind the village.");
            Room? savannah_hub = new("Savannah-Hub", "You find yourself in the savannah. If you go east you enter lion territory. In the south of here rhinos were spotted in the past. North you will enter the village.");
            Room? market = new("Market", "You enter the local market for food and other goods. Here you can talk to the local citizens and think about a spot to put up a poster.");
            Room? rhino = new("Rhino", "You have entered the rhino territory.");
            Room? lion = new("Lion", "You have entered the lion territory.");
            
            //This is where you se exits
            village_mainroad.SetExits(null, savannah_hub, market, null); // North=HUB, East, South, West

            savannah_hub.SetExits(null, lion, rhino, village_mainroad);

            market.SetExit("north", village_mainroad);

            rhino.SetExit("north", savannah_hub);

            lion.SetExit("west", savannah_hub);

            currentRoom = village_mainroad;
        }

        public void Play()
        {
            Parser parser = new();

            PrintWelcome();

            bool continuePlaying = true;
            while (continuePlaying)
            {
                Console.WriteLine(currentRoom?.ShortDescription);
                Console.Write("> ");

                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a command.");
                    continue;
                }

                Command? command = parser.GetCommand(input);

                if (command == null)
                {
                    Console.WriteLine("I don't know that command.");
                    continue;
                }

                switch (command.Name)
                {
                    case "look":
                        Console.WriteLine(currentRoom?.LongDescription);
                        break;

                    case "back":
                        if (previousRoom == null)
                            Console.WriteLine("You can't go back from here!");
                        else
                            currentRoom = previousRoom;
                        break;

                    case "north":
                    case "south":
                    case "east":
                    case "west":
                        Move(command.Name);
                        break;

                    case "quit":
                        continuePlaying = false;
                        break;

                    case "help":
                        PrintHelp();
                        break;

                    default:
                        Console.WriteLine("I don't know what command.");
                        break;
                }
            }

            Console.WriteLine("Thank you for playing Poachers and Posters! Hail the team boozemaster chief leader commander king!");
        }

        private void Move(string direction)
        {
            if (currentRoom?.Exits.ContainsKey(direction) == true)
            {
                previousRoom = currentRoom;
                currentRoom = currentRoom?.Exits[direction];
            }
            else
            {
                Console.WriteLine($"You can't go {direction}!");
            }
        }

            //CHANGE WELCOME!!
        private static void PrintWelcome()
        {
            Console.WriteLine("Welcome to the World of Zuul!");
            Console.WriteLine("World of Zuul is a new, incredibly boring adventure game.");
            PrintHelp();
            Console.WriteLine();
        }
            //CHANGE PRINT HELP
        private static void PrintHelp()
        {
            Console.WriteLine("You are lost. You are alone. You wander");
            Console.WriteLine("around the university.");
            Console.WriteLine();
            Console.WriteLine("Navigate by typing 'north', 'south', 'east', or 'west'.");
            Console.WriteLine("Type 'look' for more details.");
            Console.WriteLine("Type 'back' to go to the previous room.");
            Console.WriteLine("Type 'help' to print this message again.");
            Console.WriteLine("Type 'quit' to exit the game.");
        }
    }
}
