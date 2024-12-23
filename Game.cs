using System.ComponentModel;
using System.Globalization;

namespace WorldOfZuul;

public class Game
{
        private Printer? Printer;
        private Room? currentRoom;
        private Room? previousRoom;
        private static Inventory Inventory = new();
        Room? changing_room = new("Changing Room", "A Changing Room, where the Rangers leave their personal belongings and change into their uniform, to begin their duty. There is no one, you arrived late again. >:(");
        Room? operations_center = new("The Operations Center", "Welcome to your main office, where you get the missions intel from your Ranger Chief, it seems that there is no one, but they left the official poster with the assigned shifts and tasks.");
        Room? training_room = new("The Training Room", "Where new recruits prove their worth for ranger duty, it is primary protocol to conduct a skills check before beginning each mission.");
        Room? rest_area = new("Rest Area", "It's strange to have access to this room which is almost never used, mainly because of the broken TV, the Chief doesn't like lazy rangers.");
        Room? transfer_station = new("The Transfer Station", "Where rangers take the travel routes for their missions location, everyone already left.");

            //Africa 
        //Africa_HUB
        Region Afr = new("Afr", false);
        Room? Hub_Africa = new("Africa Sanctuary", "You are in Africa's Sanctuary, where rangers rest and prepare for missions to come. It's a great watchtower, in the middle of the forest. From here, you can see for a long distance in every direction, noticing that the poachers alraedy got here."); 

           //Mountain Forest Rooms
        Region Afr_Mf = new("Afr_Mf");
        Room? mountain_forest_path = new("Mountain Forest Path","You find yourself walking along the main path of the mountain forest, the air is fresh and humed, to the North, a remarkable building is on sight, the national sanctuary for protection and reproduction of mountain gorillas, the sancturary stands as a testament to conservation efforts, settled among the dense mountain forest foliage and rugged terrain.");
        Room? sanctuary = new("The Sanctuary", "As you step inside the sanctuary, you notice a spacious hall, filled with informative displays, strangely there is no one around, to the West of the hallway, the Rangers Office, where the local ranger ensures the safety of the sanctuary, and protects the local life from human interference, on the East side of the Hallway, you find the mountain gorillas enclosure, a cerefully designed habitat with all their required needs for their optimal development and life.");
        Room? rangers_office = new("The Rangers Office", "Once inside the rangers office, the local ranger is nowhere to be found, you find a cluttered space filled with muddy boots, maps and conversation reports, there is a coffee cup in the edge of the table, its cold, it seems that the ranger ran out of the office for some reason.");
        Room? enclosure = new("The Enclosure", "The mountain gorillas enclosure is surprisingly empty, to the North, the air feels tense, marked by a huge breach  in the enclosures wall leading to the outside forest, broken branches hint at a hurried escape, the silence adds a mistery to the situation");
        Room? mountain_forest = new("Forest", "The dense forest outside the breached wall feels with tension, sad moaning echoing from the East, your tracker picks up a signal from that direction, while two other signals pull your attention to West, deeper into the forest. Every step must be taken with caution.");
        Room? trap = new("The Trap", "You find a trapped, bleeding adult male gorilla. He's scared and looks distrustful towards you, unable to escape the trap. His moans fill the air, adding to the urgency of the moment.");
        Room? hideout = new("The Hideout", "Between the bushes, you finally find the source of the signal, a big jail trailer loaded with an adult and 2 young gorillas trapped, you spot the poachers at the distance, loading stuff and getting ready to leave with their capture, the time is ticking, you must do something.");

        // Zebra 
        Region Afr_Grass = new("Afr_Grass");
        Room? grassland = new("Grassland", "You have arrived in the Grassland.\nThe only things you can broadly see are. To the west a big tree. To the south you can see that the tall grass is ending, and it transitions into open plains.\nThe tree looks like a good spot for a poster");
        Room? tree = new("Tree", "You decided to in the direction of the tree.\nWhile approaching the tree you notice a small wooden board nailed to the tree. A bit further to the west of the tree you also notice a small rangers' hut, with a Jeep next to it.\nYou expect to find some helpful supplies in the hut.");
        Room? hut = new("Hut", "You entered the hut.\nWhen you entered you looked around and two items fell into your sight.\nFirst, keys for the jeep, which you already saw when coming here. Second, a flare gun, which could come in handy later.");
        Room? highGrass = new("High Grass", "You are driving into high grass.\nNot long after you start hearing loud sounds of hoofs hitting the ground from the south and you hear humans shouting as well.\nYou should quickly approach the area where the sounds come from.");
        Room? openPlains = new("Open plains","You arrive at the open plains.\nA big herd a zebra, is being chased by a jeep filled with poachers. The poachers know no shame and yell around to drive the zebras to exhaustion, so that they can hunt them better.\nAnnoyed by this sight you start following the poachers.");
        Room? action = new("Action", "While approaching the poachers you have two options in mind to scare away the poachers.\nEither you use the flare gun you brought with you, or you try to approach them to scare them with your presence and words.");
        
        // Elephant - 
        Region Afr_For = new("Afr_For");
        Room? forest = new("Forest", "You arrive in the thick African forest.\nYou find two paths. One of the paths leads to the south where you can see a small clearing. The other one leads to the east you can't see much there.\nMaybe you can find a good place for a poster at the small clearing.");
        Room? smallClearing = new("Small Clearing","You reached the small clearing.\nYou see a big tree seems like a good spot for a poster.");
        Room? waterhole = new("Waterhole", "You encounter a small waterhole.\nNext to the waterhole you see an elephant lying on the ground, something seems to be wrong with it.");
        Room? water = new("Water", "You got near to the water. It looks a bit weird. It seems to be poisoned!");
           
        // Savvanah 
        Region Afr_Sav = new("Afr_Sav");
        Room? village_mainroad = new("Village", "You enter a small village, the hum of the daily life around you. You are currently on the main road. In the south you see the market, in the east you see the savannah opening behind the village.");
        Room? savannah_hub = new("Savannah-Hub", "You find yourself in the savannah. If you go east you enter lion territory. In the south of here rhinos were spotted in the past. In the West you will enter the village.");
        Room? market = new("Market", "You enter the local market for food and other goods. Here you can talk to the local citizens and think about a spot to put up a poster.");
        Room? rhino = new("Rhino", "You have entered the rhino territory.");
        Room? lion = new("Lion", "As you enter the lion territory you see a little lion cub that got caught in a snare trap. Maybe you could free the lion using an item.");

        //Rhino - North
        Region Asia = new("Asia", false);
        Room? Hub_Asia = new("Asia Sanctuary", "You are in Asia's Sanctuary, where rangers rest and prepare for missions to come. It's a great watchtower, in the middle of the forest. From here, you can see for a long distance in every direction, noticing that the poachers alraedy got here.");

        Region Asia_Grass = new("Asia_Grass");
        Room? Villlage_Rhino = new("Rhino Village", "You are in the Village. You notice a big apple tree in the middle of the town square, full of red fruits. The village is filled with small huts, with people going around, busy. You notice the mayor coming over to you.");
        Room? Rhino_Room = new("Grasslands", "You have arrived in the rhino's territory. You notice the poachers have been here, by the tire tracks in the mud and different items discarded in the grass.The old rhino is lying on the ground under a great tree, looking scared.");
            
        //Tiger - East 
        Region Asia_Swamp = new("Asia_Swamp");
        Room? Ranger_Meeting = new("Edge of the Swap", "You have arrived at the edge of the swamp, where you notice an old ranger looking worried towards the marshes.");
        Room? Marsh1 = new("In the Swamp", "You are now in the Swamp. The scenery looks the same as five minutes ago, but you feel like you are on the right track");
        Room? Marsh2 = new("In the Swamp", "You've entered what seems to be an administration office. There's a large desk with a computer on it, and some bookshelves lining one wall.");
        Room? Marsh_Tiger = new("In The Heart of the Swamp", "You have arrived in the middle of the Swamp, where you notice the tiger struggling under a fallen tree. ");

        //Ourangutans
        Region Asia_Jungle = new("Asia_Jungle");
        Room? jungle = new("Jungle","You have arrived in the jungle. The poachers are no where to be seen but there are some footsteps heading east. Maybe it's worth investigating.");
        Room? orangutans = new("Ourangutans group", "You wander around the jungle when you find a group of ourangutans. You notice the group has lost three their babies, so you decide to go venture in the misterious jungle to find and rescue them.");

        //Jaguar and where the baby orangutans are
        Room? cave = new("Cave", "Inside the cave there is darkness but you can hear sounds coming from deep inside the cave... how misterious..?");
        Room? cave_entrance = new("Entrance of the cave", "Around the cave entrance there are some rare plants that can be used to treat wounds. I wonder how would that be useful to anything?");
        Room? deeper_cave = new("Deep into the cave","In the complete darkness you can hear some sounds. We could expect the poachers to be here hiding. Or maybe it was... the wind? Nothing can be certain unless we explore.");
        Room? Road = new("Road", "As you walk back to your base of operations, you notice car tracks leading north. Perhaps you should follow them.");
        Room? Camp = new("Camp", "You arrive in a poacher camp, where you notice a caged Amur leopard, one of the rarest species in the world. It should be realeased");
        Room? Ranger_Hall = new("Ranger Hall", "You are now in the Ranger Hall, a great room, filled with rangers, young and old, here to celebrate your accomplishments. For your deeds, you shall receive a medal and officially become a true defender of nature.");
        Room? testarea = new("Test Area","");

        //This is where you set exits
        public Game()
        {
            Hub_Africa.SetRoomRegion(Afr);
            mountain_forest_path.SetRoomRegion(Afr_Mf);sanctuary.SetRoomRegion(Afr_Mf);
            rangers_office.SetRoomRegion(Afr_Mf);enclosure.SetRoomRegion(Afr_Mf);
            mountain_forest.SetRoomRegion(Afr_Mf);trap.SetRoomRegion(Afr_Mf);hideout.SetRoomRegion(Afr_Mf);
            grassland.SetRoomRegion(Afr_Grass);tree.SetRoomRegion(Afr_Grass); hut.SetRoomRegion(Afr_Grass);
            highGrass.SetRoomRegion(Afr_Grass);openPlains.SetRoomRegion(Afr_Grass);action.SetRoomRegion(Afr_Grass);
            forest.SetRoomRegion(Afr_For);smallClearing.SetRoomRegion(Afr_For);
            waterhole.SetRoomRegion(Afr_For);water.SetRoomRegion(Afr_For); 
            village_mainroad.SetRoomRegion(Afr_Sav);savannah_hub.SetRoomRegion(Afr_Sav); 
            market.SetRoomRegion(Afr_Sav);rhino.SetRoomRegion(Afr_Sav);lion.SetRoomRegion(Afr_Sav);
            Hub_Asia.SetRoomRegion(Asia);
            Villlage_Rhino.SetRoomRegion(Asia_Grass);Rhino_Room.SetRoomRegion(Asia_Grass);
            Ranger_Meeting.SetRoomRegion(Asia_Swamp);Marsh1.SetRoomRegion(Asia_Swamp);
            Marsh2.SetRoomRegion(Asia_Swamp);Marsh_Tiger.SetRoomRegion(Asia_Swamp);
            jungle.SetRoomRegion(Asia_Jungle);orangutans.SetRoomRegion(Asia_Jungle);cave.SetRoomRegion(Asia_Jungle);
            cave_entrance.SetRoomRegion(Asia_Jungle);deeper_cave.SetRoomRegion(Asia_Jungle);

            changing_room.SetExit("east", operations_center);
            operations_center.SetExits(training_room, transfer_station, Hub_Africa, changing_room); 
                                  //⬍⬍ North,         East,             South,     West ⬍
            transfer_station.SetExit("west", operations_center);
            training_room.SetExit("south", operations_center);
                //Africa
            Hub_Africa.SetExits(forest, village_mainroad, grassland, mountain_forest_path);
            // Grasslands
            grassland.SetExits(Hub_Africa, null, highGrass, tree);

            tree.SetExits(null, grassland, null, hut);
            hut.SetExit("east", tree);
            highGrass.SetExit("south", openPlains);
            openPlains.SetExit("south", action);
            // Forest
            forest.SetExits(null, waterhole, Hub_Africa , smallClearing);
            smallClearing.SetExit("east", forest);
            waterhole.SetExit("north", water);
            water.SetExit("south", waterhole);
            waterhole.SetExit("north", water);
            water.SetExit("south", waterhole);
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
            currentRoom = market; 


            // ITEM ASSIGN TO ROOMS HERE
            // Definition: 
            // Item [name of item] = new("[Name]","[Description]")
            //TEST ITEMS
            Item item1 = new("Item1", "It can be found in the Africa HUB");
            //ADD ITEMS TO SPECIFIC ROOMS:
            // To add items in rooms write down here: [room_name].AddItem([name of item])
            Hub_Africa.AddItem(item1);
            

            Item Knife = new("Knife", "A sharp knife. Maybe you can cut something with it...");
            Item apple = new("Apple", "A big, ripe apple. It would be a good treat for an animal.");
            
            //ADD ITEMS TO SPECIFIC ROOMS:
            // To add items in rooms write down here: [room_name].AddItem([name of item])
            testarea.AddItem(item1);
            savannah_hub.AddItem(Knife);
            Villlage_Rhino.AddItem(apple);

            //Decision Room: Action
             List<string> scareOptions = new List<string>
                {
                    "Use the flare gun",
                    "Don't use the flare gun and confront the poachers yourself"
                };

                Dictionary<int, string> scareResults = new Dictionary<int, string>
                {
                    {1, "You take the flare gun out of your pocket and aim it into the sky.\nWith a loud bang you shoot the flare into the sky. It explodes with another loud bang.\nThe poachers, seemingly scared and shocked by the noise, flee into the wilderness.\nBut just after the poachers went into a different direction, you notice the herd of zebras scattering apart.\nThey are in even more panic than before, some of them disoriented, not knowing where to go.\nYou now are in the thought that your actions, even though you scared off the poachers, made the zebras even more traumatized than they were before."},
                    {2, "You step on the gas until you are right next to the poachers' Jeep.\nYou roll down your window and shout, “You are under arrest! Stop right now or face the consequences! I have reinforcements on the way!”\nThe poachers look and you with fear of being caught.They also seem to fear the possible reinforcement, which you lied about.\nFortunately, they decide to escape into the wilderness. The zebras were able to come to a stop.\nThey seem tired but are luckily unharmed. You are relieved. You were able to resolve the problem without harming anybody and without putting yourself in further danger."}
                };

                Choice scareChoice = new Choice("How would you like to scare away the poachers?", scareOptions, scareResults);
                action.SetChoice(scareChoice);

                //Decision Room: Waterhole
                List<string> followOptions = new List<string>
                {
                    "Help the elephant and let the poachers go",
                    "Follow the poachers and help the elephant later"
                };

                Dictionary<int, string> followResults = new Dictionary<int, string>
                {
                    {1, "You take out the chest you found earlier and take out the antidote.\nAfter infusing the antidote to the elephant, the elephant stabilized.\nYou still must find the reason for the poisoning. \nYou should examine the water in the waterhole to the north."},
                    {2, "You chose to chase after the poachers, they escape in their jeep before you can catch up to them.\nBy the time you return, you hear the elephant make loud noises and you rush to him to give him the antidote.\nYou successfully helped the elephant, but it suffered a great loss. The elephant does not have feelings in his front right leg and can’t walk properly now.\nYou feel guilty and disappointed in yourself, but you still should find the reason for the poisoning.\nYou should examine the water in the waterhole to the north."}
                };

                Choice followChoice = new Choice("What will you do Safe the elephant first or follow the poachers?", followOptions, followResults);
                waterhole.SetChoice(followChoice);

                //Decision Room: Water
                List<string> neutralizeOptions = new List<string>
                {
                    "Use the neutralizer from the box",
                    "Keep the neutralizer for something else"
                };

                Dictionary<int, string> neutralizeResults = new Dictionary<int, string>
                {
                    {1, "Using the neutralizer from the chest, you cleanse the water, ensuring that no other animals will fall victim."},
                    {2, "You decided to not use the neutralizer. You can't change your mind anymore!"}
                };

                Choice neutralizerChoice = new Choice("The water seems to be poisoned will you use the neutralizer or not?",neutralizeOptions, neutralizeResults);
                water.SetChoice(neutralizerChoice);

                //Decisions Room: Rhino
                List<string> rhinoOptions = new List<string>
                {
                    "Stop the local villagers from cutting the rhinos horn.",
                    "Don't stop them, because they need the profit from the horn to survive."
                };

                Dictionary<int, string> rhinoResults = new Dictionary<int, string>
                {
                    {1, "You remember someone told you, the villagers don't need to poach for food. Hence you decide to run at the villagers screaming loudly at them. They get scared and run off. You inject an antidote for the rhino and shortly after it wakes up. Great job!"},
                    {2, "Because you feel pity for the villagers you don't intervene. They cut off the rhinos horn and shortly after it dies. Afterwards you remember someone telling you, the villagers poach for reasons of superstitons. You regret your choice!"}
                };

                Choice rhinoChoice = new Choice("You see two poachers who stand right next to a tranquilized rhino. They want to cut off its horn. As you move closer, you notice these are people from the village, who probably poach these animals for survival, not for fun or becomming rich. You feel conflicted. Should you intervene or not?", rhinoOptions, rhinoResults);
                rhino.SetChoice(rhinoChoice);

                 //Decisions Room: Tiger
                List<string> tigerOptions = new List<string>
                {
                    "Quickly saved the trapped tiger.",
                    "Go for the poacher's notebook before it sinks"
                };

                Dictionary<int, string> tigerResults = new Dictionary<int, string>
                {
                    {1, "The tiger is saved, he looks at you, then jumps back towards the deep marsh. You are sure there was nothing useful in the notebook anyway"},
                    {2, "You quickly dash and get the notebook. You quickly notice it is not readable due to the mud and water. After this, you save the tiger, which apprears maimed due to the time it was trapped. Regrets overwhelm you."}
                };

                Choice tigerChoice = new Choice("You notice the trapped tiger and the sinking notebook. Which one do you go for the first?", tigerOptions, tigerResults);
                rhino.SetChoice(rhinoChoice);


                //Add NPC here:
                NPC Charles = new("Charles", "Some guy from the African village", "Wealth", "Supersitions", "Lion", "Our village is quite wealthy, we never need to kill animals for food.", "My sons went out to hunt rhinos because we believe there ivory has mystic powers.", "Why did the lion eat the tightrope walker? Because he wanted a well-balanced meal! HAHAHA!");
                market.RoomNPC = Charles;

                NPC Elder = new("Elder","A Village Elder","Rhino","Enviroment","Poaching", "There is an old Rhino ahead of this village. When the poachers came, they scared him. He is now very aggresive, help him please.", "This is one of the places where humans didn't get to destroy the world around them", "Poachers have been seen around this village many times, hunting the old rhino for his horn. Someone must put a stop to them." );
                Villlage_Rhino.RoomNPC = Elder;

                NPC Ranger = new("Old Ranger", "An old, tired looking ranger", "The tigers", "The swamps",null, "The tigers in this swamp are magnificent creatures. They are rare and mostly run away from humans, but the poachers still try to find them. Try going after the hunters, please. I am too old for this...", "Take care when you go in the swamp. Maybe try to stick to the same direction, it might help. Good luck!", null);
                //Add Chance instances here:
                Chance test = new("You throw the knife.", "You miss and you cry", "You hit your target. Lucky.");
                testarea.RoomChance = test;
                Chance test2 = new("You play the game machine", "You are not good at video games and so you lose", "Hoorray, it's your lucky day. You win!");
                market.RoomChance = test2;
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

                string? input = Console.ReadLine(); //reads player input

                if (string.IsNullOrEmpty(input)) //checks for empty line input
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
                        if (currentRoom?.roomChoice() != null)
                        {
                            int choice = currentRoom.roomChoice().MakeChoice();

                            //Display the result of your choice with GetResult method
                            string result = currentRoom.roomChoice().GetResult(choice);

                            /*Could be useful if we want a command to be executed as a result of a Choice
                            if (result.StartsWith("cmd:"))
                            {
                                string cmd = result.Substring(4);
                                ProcessCommand(cmd);
                            }
                            */
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(result);
                            Console.ResetColor();

                            //If the choices are supposed to be one-time only if not we need to take that out
                            currentRoom.SetterChoice(null);
                        }
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
                        Printer.ExitMessage(Inventory.Rep());
                        break;

                    case "commands":
                    case "cmds":
                        Printer.PrintCmds();
                        break;

                    case "inventory": //Self-explanitory I presume
                    case "inv":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Your reputation is: {Inventory.Rep()}");
                        Console.ResetColor();
                        Inventory?.SeeInventory();
                        break;

                    case "take": //The player takes a specific item from a room
                        Inventory?.Take(currentRoom, command.SecondWord);
                        break;
         
                    case "throw": //Player puts an item from the inventory in the current room theyre in
                        Inventory?.Throw(currentRoom, command.SecondWord);
                        break;
                                         
                    case "give": //Will be MOVED to the NPC class soon
                        if(Inventory?.IsEmpty() == false)
                        {
                            Item? a = Inventory.FindItemInInv(command.SecondWord);
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
                  
                    case "view": 
                        currentRoom?.View();
                        break;
                    
                    case "use":
                        Inventory?.Use(currentRoom!);
                        break;
                        
                    case "poster":
                        currentRoom?.FindRegion().SetPosters(Inventory);
                        Console.ResetColor();
                        break;

                    case "talk":
                        {
                            currentRoom?.RoomNPC.TalkNPC();
                            switch(Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                currentRoom?.RoomNPC.Case1();
                                break;
                                 case ConsoleKey.D2:
                                currentRoom?.RoomNPC.Case2();
                                break;
                                 case ConsoleKey.D3:
                                currentRoom?.RoomNPC.Case3();
                                break;
                            }
                        }
                        break;

                    case "chance":
                        {
                            int? var = currentRoom?.RoomChance.ThrowDice();
                            switch(var)
                                case 1:
                                    Inventory.ChangeRep(10);
                                    break;
                                default:
                                    
                                
                            Console.Clear();
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