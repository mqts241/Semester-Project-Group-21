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
                //Africa 
           //Africa_HUB
           Room? Hub_Africa = new("Africa Sanctuary", "You are in Africa's Sanctuary, where rangers rest and prepare for missions to come. It's a great watchtower, in the middle of the forest. From here, you can see for a long distance in every direction, noticing that the poachers alraedy got here.");

           // Zebra -
           Room? grassland = new("Grassland", "You have arrived in the Grassland. The only things you can broadly see are. To the west a big tree. To the south you can see that the tall grass is ending, and it transitions into open plains. The tree looks like a good spot for a poster");
           Room? tree = new("Tree", "You decided to go west in the direction of the tree. While approaching the tree you notice a small wooden board nailed to the tree. A bit further to the west of the tree you also notice a small rangers' hut, with a Jeep next to it. You expect to find some helpful supplies in the hut.");
           Room? hut = new("Hut", "You entered the hut. When you entered you looked around and two items fell into your sight. First, keys for the jeep, which you already saw when coming here. Second, a flare gun, which could come in handy later.");
           Room? highGrass = new("High Grass", "You are driving into high grass. Not long after you start hearing loud sounds of hoofs hitting the ground from the south and you hear humans shouting as well. You quickly approach the area where the sounds come from.");
           Room? openPlains = new("Open plains","You arrive at the open plains. A big herd a zebra, is being chased by a jeep filled with poachers. The poachers know no shame and yell around to drive the zebras to exhaustion, so that they can hunt them better. Annoyed by this sight you start following the poachers.");
           Room? action = new("Action", "While approaching the poachers you have two options in mind to scare away the poachers. Either you use the flare gun you brought with you, or you try to approach them to scare them with your presence and words.");
           
           // Elephant - 
           Room? forest = new("Forest", "You arrive in the thick African forest. You find two paths. One of the paths leads to the south where you can see a small clearing. The other one leads to the east you can't see much there. Maybe you can find a good place for a poster there.");
           Room? smallClearing = new("Small Clearing","You reached the small clearing. You see a big tree seems like a good spot for a poster.");
           Room? waterhole = new("Waterhole", "You followed the path to the east. There you encounter a small waterhole. Next to the waterhole you see an elephant lying on the ground, something seems to be wrong with it.");
           Room? deepForest = new("Deep Forest", "You chose to chase after the poachers, they escape in their jeep before you can catch up to them."); 
           
           // Savvanah -
           Room? village_mainroad = new("Village", "You enter a small village, the hum of the daily life around you. You are currently on the main road. In the south you see the market, in the east you see the savannah opening behind the village.");
           Room? savannah_hub = new("Savannah-Hub", "You find yourself in the savannah. If you go east you enter lion territory. In the south of here rhinos were spotted in the past. North you will enter the village.");
           Room? market = new("Market", "You enter the local market for food and other goods. Here you can talk to the local citizens and think about a spot to put up a poster.");
           Room? rhino = new("Rhino", "You have entered the rhino territory.");
           Room? lion = new("Lion", "You have entered the lion territory.");
            //Rhino - North
           Room? Hub_Asia = new("Asia Sanctuary", "You are in Asia's Sanctuary, where rangers rest and prepare for missions to come. It's a great watchtower, in the middle of the forest. From here, you can see for a long distance in every direction, noticing that the poachers alraedy got here.");
           Room? Villlage_Rhino = new("Village", "You are in the Village. You notice a big apple tree in the middle of the town square, full of red fruits. The village is filled with small huts, with people going around, busy. You notice the mayor coming over to you.");
           Room? Rhino_Room = new("Grasslands", "You have arrived in the rhino's territory. You notice the poachers have been here, by the tire tracks in the mud and different items discarded in the grass.The old rhino is lying on the ground under a great tree, looking scared.");
            
            //Tiger - East 
           Room? Ranger_Meeting = new("Edge of the Swap", "You have arrived at the edge of the swamp, where you notice an old ranger looking worried towards the marshes.");
           Room? Marsh1 = new("In the Swamp", "You are now in the Swamp. The scenery looks the same as five minutes ago, but you feel like you are on the right track");
           Room? Marsh2 = new("In the Swamp", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");
           Room? Marsh_Tiger = new("In The Heart of the Swamp", "You have arrived in the middle of the Swamp, where you notice the tiger struggling under a fallen tree. You also notice a notebook, dropped into the water, slowly sinking. It is time to make a choice.");
          
           Room? jungle = new("Jungle","You have arrived in the jungle. The poachers are no where to be seen but there are some footsteps heading east. Maybe it's worth investigating.");
           Room? orangutans = new("Ourangutans group", "You wander around the jungle when you find the group of ourangutans. You notice the group has lost their ");

            //Jaguar and where the baby orangutans are
           Room? cave = new("Cave", "Inside the cave there is darkness but you can hear sounds coming from deep inside the cave... how misterious..?");
           Room? cave_entrance = new("Entrance of the cave", "Around the cave entrance there are some rare plants that can be used to treat wounds. I wonder how would that be useful to anything?");
           Room? deeper_cave = new("Deep into the cave","In the complete darkness you can hear some sounds. We could expect the poachers to be here hiding. Or maybe it was... the wind? Nothing can be certain unless we explore.");
          
           //This is where you se exits
          
                      //Africa
           
            Hub_Africa.SetExits(forest, village_mainroad, grassland, tree);
           
            // Grasslands
            grassland.SetExits(null, null, highGrass, tree);

            tree.SetExits(null, grassland, null, hut);

            hut.SetExit("east", tree);

            highGrass.SetExit("south", openPlains);

            openPlains.SetExit("south", action);
           
            // Forest
            forest.SetExits(null, waterhole, Hub_Africa , smallClearing);

            smallClearing.SetExit("east", forest);

            waterhole.SetExit("north", deepForest);

            deepForest.SetExit("south", waterhole);
            
            // Savvanah
            village_mainroad.SetExits(null, savannah_hub, market, Hub_Africa); // North=HUB, East, South, West

            savannah_hub.SetExits(null, lion, rhino, village_mainroad);

            market.SetExit("north", village_mainroad);

            rhino.SetExit("north", savannah_hub);

            lion.SetExit("west", savannah_hub);
            
            //Asia
            Hub_Asia.SetExits(Rhino_Room, Ranger_Meeting, jungle, null); // North, East, South, West
            
            //Rhino
            Villlage_Rhino.SetExits(Rhino_Room, null , Hub_Asia, null);
            Rhino_Room.SetExits(null, null, Villlage_Rhino, null);
            
            //Tiger
            Ranger_Meeting.SetExits(null, Marsh1, null, Hub_Asia);
            Marsh1.SetExits(null, Marsh2, null, null);
            Marsh2.SetExits(Marsh1, Marsh_Tiger, Marsh1, Marsh1); // This is a maze so the player gets and lost sad and with no hopes and dreams in life 
            Marsh_Tiger.SetExits(null, null, null, Hub_Asia);


            //Ourangutans
            jungle.SetExit("east", orangutans);
            jungle.SetExit("west",cave_entrance);
            jungle.SetExit("south", null); //Mountain hill connection for the final part of the game
            jungle.SetExit("north", Hub_Asia);
            //Ourangutans
            orangutans.SetExit("west", jungle);
            
            //Cave
            cave_entrance.SetExit("south", cave);
            cave_entrance.SetExit("east", jungle);
            cave.SetExit("north", cave_entrance);
            cave.SetExit("south", deeper_cave);
            deeper_cave.SetExit("east",jungle);
            currentRoom = rhino;
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
            Console.WriteLine("\n\n\t\t  ____                  _                      ___     ____           _                ");
            Console.WriteLine("\t\t |  _ \\ ___   __ _  ___| |__   ___ _ __ ___   ( _ )   |  _ \\ ___  ___| |_ ___ _ __ ___ ");
            Console.WriteLine("\t\t | |_) / _ \\ / _` |/ __| '_ \\ / _ \\ '__/ __|  / _ \\/\\ | |_) / _ \\/ __| __/ _ \\ '__/ __|"); 
            Console.WriteLine("\t\t |  __/ (_) | (_| | (__| | | |  __/ |  \\__ \\ | (_>  < |  __/ (_) \\__ \\ ||  __/ |  \\__ \\");
            Console.WriteLine("\t\t |_|   \\___/ \\__,_|\\___|_| |_|\\___|_|  |___/  \\___/\\/ |_|   \\___/|___/\\__\\___|_|  |___/\n\n\n");
            Console.WriteLine();
        }
            //CHANGE PRINT HELP
        private static void PrintHelp()
        {
            Console.WriteLine("You are lost. You are ALONE.\n");
            Console.WriteLine("Navigate by typing 'north', 'south', 'east', or 'west'.");
            Console.WriteLine("Type 'look' for more details.");
            Console.WriteLine("Type 'back' to go to the previous room.");
            Console.WriteLine("Type 'help' to print this message again.");
            Console.WriteLine("Type 'quit' to exit the game.");
        }
    }
}
