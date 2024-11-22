using System.ComponentModel;
using System.Globalization;

namespace WorldOfZuul;

public class Game
{
        private Printer? Printer;
        private Room? currentRoom;
        private Room? previousRoom;
        private static Inventory Inventory = new();
        private int Reputation { get; set; } = 0;
        Room? changing_room = new("Changing Room", "A Changing Room, where the Rangers leave their personal belongings and change into their uniform, to begin their duty. There is no one, you arrived late again. >:(");
        Room? operations_center = new("The Operations Center", "Welcome to your main office, where you get the missions intel from your Ranger Chief, it seems that there is no one, but they left the official poster with the assigned shifts and tasks.");
        Room? training_room = new("The Training Room", "Where new recruits prove their worth for ranger duty, it is primary protocol to conduct a skills check before beginning each mission.");
        Room? rest_area = new("Rest Area", "It's strange to have access to this room which is almost never used, mainly because of the broken TV, the Chief doesn't like lazy rangers.");
        Room? transfer_station = new("The Transfer Station", "Where rangers take the travel routes for their missions location, everyone already left.");

            //Africa 
        //Africa_HUB
        Room? Hub_Africa = new("Africa Sanctuary", "You are in Africa's Sanctuary, where rangers rest and prepare for missions to come. It's a great watchtower, in the middle of the forest. From here, you can see for a long distance in every direction, noticing that the poachers alraedy got here.", "Afr");

           //Mountain Forest Rooms
        Room? mountain_forest_path = new("Mountain Forest Path","You find yourself walking along the main path of the mountain forest, the air is fresh and humed, to the North, a remarkable building is on sight, the national sanctuary for protection and reproduction of mountain gorillas, the sancturary stands as a testament to conservation efforts, settled among the dense mountain forest foliage and rugged terrain.", "Afr_Mf");
        Room? sanctuary = new("The Sanctuary", "As you step inside the sanctuary, you notice a spacious hall, filled with informative displays, strangely there is no one around, to the West of the hallway, the Rangers Office, where the local ranger ensures the safety of the sanctuary, and protects the local life from human interference, on the East side of the Hallway, you find the mountain gorillas enclosure, a cerefully designed habitat with all their required needs for their optimal development and life.", "Afr_Mf");
        Room? rangers_office = new("The Rangers Office", "Once inside the rangers office, the local ranger is nowhere to be found, you find a cluttered space filled with muddy boots, maps and conversation reports, there is a coffee cup in the edge of the table, its cold, it seems that the ranger ran out of the office for some reason.", "Afr_Mf");
        Room? enclosure = new("The Enclosure", "The mountain gorillas enclosure is surprisingly empty, to the North, the air feels tense, marked by a huge breach  in the enclosures wall leading to the outside forest, broken branches hint at a hurried escape, the silence adds a mistery to the situation", "Afr_Mf");
        Room? mountain_forest = new("Forest", "The dense forest outside the breached wall feels with tension, sad moaning echoing from the East, your tracker picks up a signal from that direction, while two other signals pull your attention to West, deeper into the forest. Every step must be taken with caution.", "Afr_Mf");
        Room? trap = new("The Trap", "You find a trapped, bleeding adult male gorilla. He's scared and looks distrustful towards you, unable to escape the trap. His moans fill the air, adding to the urgency of the moment.", "Afr_Mf");
        Room? hideout = new("The Hideout", "Between the bushes, you finally find the source of the signal, a big jail trailer loaded with an adult and 2 young gorillas trapped, you spot the poachers at the distance, loading stuff and getting ready to leave with their capture, the time is ticking, you must do something.", "Afr_Mf");

        // Zebra -
        Room? grassland = new("Grassland", "You have arrived in the Grassland. The only things you can broadly see are. To the west a big tree. To the south you can see that the tall grass is ending, and it transitions into open plains. The tree looks like a good spot for a poster", "Afr_Grass");
        Room? tree = new("Tree", "You decided to go west in the direction of the tree. While approaching the tree you notice a small wooden board nailed to the tree. A bit further to the west of the tree you also notice a small rangers' hut, with a Jeep next to it. You expect to find some helpful supplies in the hut.", "Afr_Grass");
        Room? hut = new("Hut", "You entered the hut. When you entered you looked around and two items fell into your sight. First, keys for the jeep, which you already saw when coming here. Second, a flare gun, which could come in handy later.", "Afr_Grass");
        Room? highGrass = new("High Grass", "You are driving into high grass. Not long after you start hearing loud sounds of hoofs hitting the ground from the south and you hear humans shouting as well. You quickly approach the area where the sounds come from.", "Afr_Grass");
        Room? openPlains = new("Open plains","You arrive at the open plains. A big herd a zebra, is being chased by a jeep filled with poachers. The poachers know no shame and yell around to drive the zebras to exhaustion, so that they can hunt them better. Annoyed by this sight you start following the poachers.", "Afr_Grass");
        Room? action = new("Action", "While approaching the poachers you have two options in mind to scare away the poachers. Either you use the flare gun you brought with you, or you try to approach them to scare them with your presence and words.", "Afr_Grass");
           
        // Elephant - 
        Room? forest = new("Forest", "You arrive in the thick African forest. You find two paths. One of the paths leads to the south where you can see a small clearing. The other one leads to the east you can't see much there. Maybe you can find a good place for a poster there.", "Afr_For");
        Room? smallClearing = new("Small Clearing","You reached the small clearing. You see a big tree seems like a good spot for a poster.", "Afr_For");
        Room? waterhole = new("Waterhole", "You followed the path to the east. There you encounter a small waterhole. Next to the waterhole you see an elephant lying on the ground, something seems to be wrong with it.", "Afr_For");
        Room? deepForest = new("Deep Forest", "You chose to chase after the poachers, they escape in their jeep before you can catch up to them.", "Afr_For"); 
           
        // Savvanah -
        Room? village_mainroad = new("Village", "You enter a small village, the hum of the daily life around you. You are currently on the main road. In the south you see the market, in the east you see the savannah opening behind the village.", "Afr_Sav");
        Room? savannah_hub = new("Savannah-Hub", "You find yourself in the savannah. If you go east you enter lion territory. In the south of here rhinos were spotted in the past. North you will enter the village.", "Afr_Sav");
        Room? market = new("Market", "You enter the local market for food and other goods. Here you can talk to the local citizens and think about a spot to put up a poster.", "Afr_Sav");
        Room? rhino = new("Rhino", "You have entered the rhino territory.", "Afr_Sav");
        Room? lion = new("Lion", "You have entered the lion territory.", "Afr_Sav");

        //Rhino - North
        Room? Hub_Asia = new("Asia Sanctuary", "You are in Asia's Sanctuary, where rangers rest and prepare for missions to come. It's a great watchtower, in the middle of the forest. From here, you can see for a long distance in every direction, noticing that the poachers alraedy got here.", "Asia");
        Room? Villlage_Rhino = new("Village", "You are in the Village. You notice a big apple tree in the middle of the town square, full of red fruits. The village is filled with small huts, with people going around, busy. You notice the mayor coming over to you.", "Asia_Grass");
        Room? Rhino_Room = new("Grasslands", "You have arrived in the rhino's territory. You notice the poachers have been here, by the tire tracks in the mud and different items discarded in the grass.The old rhino is lying on the ground under a great tree, looking scared.", "Asia_Grass");
            
        //Tiger - East 
        Room? Ranger_Meeting = new("Edge of the Swap", "You have arrived at the edge of the swamp, where you notice an old ranger looking worried towards the marshes.", "Asia_Swamp");
        Room? Marsh1 = new("In the Swamp", "You are now in the Swamp. The scenery looks the same as five minutes ago, but you feel like you are on the right track", "Asia_Swamp");
        Room? Marsh2 = new("In the Swamp", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.", "Asia_Swamp");
        Room? Marsh_Tiger = new("In The Heart of the Swamp", "You have arrived in the middle of the Swamp, where you notice the tiger struggling under a fallen tree. You also notice a notebook, dropped into the water, slowly sinking. It is time to make a choice.", "Asia_Swamp");

        //Ourangutans
        Room? jungle = new("Jungle","You have arrived in the jungle. The poachers are no where to be seen but there are some footsteps heading east. Maybe it's worth investigating.", "Asia_Jungle");
        Room? orangutans = new("Ourangutans group", "You wander around the jungle when you find a group of ourangutans. You notice the group has lost three their babies, so you decide to go venture in the misterious jungle to find and rescue them.", "Asia_Jungle");

        //Jaguar and where the baby orangutans are
        Room? cave = new("Cave", "Inside the cave there is darkness but you can hear sounds coming from deep inside the cave... how misterious..?", "Asia_Jungle");
        Room? cave_entrance = new("Entrance of the cave", "Around the cave entrance there are some rare plants that can be used to treat wounds. I wonder how would that be useful to anything?", "Asia_Jungle");
        Room? deeper_cave = new("Deep into the cave","In the complete darkness you can hear some sounds. We could expect the poachers to be here hiding. Or maybe it was... the wind? Nothing can be certain unless we explore.", "Asia_Jungle");
        
        //EPILOGUE
        Room? Road = new("Road", "As you walk back to your base of operations, you notice car tracks leading north. Perhaps you should follow them.");
        Room? Camp = new("Camp", "You arrive in a poacher camp, where you notice a caged Amur leopard, one of the rarest species in the world. It should be realeased");
        Room? Ranger_Hall = new("Ranger Hall", "You are now in the Ranger Hall, a great room, filled with rangers, young and old, here to celebrate your accomplishments. For your deeds, you shall receive a medal and officially become a true defender of nature.");


        //This is where you set exits
        public Game()
        {
            //Start-Point Hub Exits
            changing_room.SetExit("east", operations_center);
            operations_center.SetExits(training_room, transfer_station, Hub_Africa, changing_room); 
                                  //⬍⬍ North,         East,             South,     West ⬍
            transfer_station.SetExit("west", operations_center);
            training_room.SetExit("south", operations_center);
                //Africa
            Hub_Africa.SetExits(forest, village_mainroad, grassland, mountain_forest_path);
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
            //Mountain Forest Exits
            mountain_forest_path.SetExits(sanctuary, Hub_Africa, null, null); 
            sanctuary.SetExits(null, enclosure, mountain_forest_path, rangers_office);
            rangers_office.SetExit("east", sanctuary);
            enclosure.SetExits(mountain_forest, null, null, sanctuary);
            mountain_forest.SetExits(null, trap, enclosure, hideout);
            trap.SetExit("west", mountain_forest);
            hideout.SetExit("east", mountain_forest);
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
            //Jaguar and Ourangutans
            jungle.SetExits(Hub_Asia, cave_entrance, null, orangutans); //connect the final area in south
            orangutans.SetExit("east", jungle);
            cave_entrance.SetExits(null, jungle, cave, null);
            cave.SetExits(cave_entrance, null, deeper_cave, null);
            deeper_cave.SetExit("east",jungle);
            //Epilogue
            Road.SetExits(Camp, null, null, null);
            Camp.SetExits(null, null, Ranger_Hall, null);

            //SET THE CURRENT ROOM AS THE STARTING ROOM
            currentRoom = changing_room;

            // ITEM ASSIGN TO ROOMS HERE
            // Definition: 
            // Item [name of item] = new("[Name]","[Description]")
            //TEST ITEMS
            Item item1 = new("Item1", "It can be found in the Africa HUB");
            Item apple = new("Apple", "A big, ripe apple. It would be a good treat for an animal.");
            //ADD ITEMS TO SPECIFIC ROOMS:
            // To add items in rooms write down here: [room_name].AddItem([name of item])
            Hub_Africa.AddItem(item1);
            Villlage_Rhino.AddItem(apple);
        }
    
        public void Play()
        {
            Parser parser = new();

            Printer.PrintWelcome();

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

                switch(command.Name)
                {
                    case "look":
                        currentRoom?.PrintDescription();
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
                        Printer.GameOver();
                        Printer.ExitMessage(Reputation);
                        break;

                    case "commands":
                    case "cmds":
                        Printer.PrintCmds();
                        break;

                    case "inventory": //Self-explanitory I presume
                    case "inv":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Your reputation is: {Reputation}");
                        Console.ResetColor();
                        Inventory?.SeeInventory();
                        break;

                    case "take": //The player takes a specific item from a room
                        Inventory?.Take(currentRoom, command.SecondWord!);
                        break;
         
                    case "throw": //Player puts an item from the inventory in the current room theyre in
                        Inventory?.Throw(currentRoom, command.SecondWord!);
                        break;
                                         
                    case "give": //Will be MOVED to the NPC class soon
                        if(Inventory?.IsEmpty() == false)
                        {
                            Item? a = Inventory.FindItemInInv(command.SecondWord!);
                            if(a != null)
                            {
                                Console.WriteLine($"You have given your {a.Name} to <NPCname>");
                                Inventory.RemoveItem(a);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"You dont have {command.SecondWord} in your inventory.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You can't give something when you have nothing!");
                            Console.ResetColor();
                        }
                        break;
                  
                    case "view":   //COMMAND USED FOR TESTING TO SEE WHERE THE ITEMS ARE IN EACH ROOM
                        currentRoom?.View();
                        break;
                        
                    case "poster":
                        currentRoom?.FindRegion().SetPosters(Inventory);
                        Console.ResetColor();
                        break;
                    
                    case "talk":
                        {
                            currentRoom.RoomNPC.TalkNPC();
                            
                            switch(Console.ReadKey(true).Key)
                            {
                             case ConsoleKey.NumPad1:
                             Console.WriteLine(currentRoom.RoomNPC.T1);
                             break;
                             
                             case ConsoleKey.NumPad2:
                             Console.WriteLine(currentRoom.RoomNPC.T2);
                             break;
                             
                             case ConsoleKey.NumPad3:
                             Console.WriteLine(currentRoom.RoomNPC.T3);
                             break;
                        }
                        break;
                        }

                    
                    default:
                        Console.WriteLine("I don't know that command.");
                        break;
                }
            }
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
}