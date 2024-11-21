namespace WorldOfZuul;

public class Region{
  public string? Name { get; set; }
  private bool HasPoster { get; set; } = false;
  public void SetPosters(int reputation){
    int maxlenght = 99;
    bool view = true;
    if(HasPoster == false){
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Would you like to place a poster? [Press 'Y' for yes and 'N' for no]");
      switch(Console.ReadKey(true).Key)
      {
        case ConsoleKey.Y:
          view=true;
          Console.Write("You have placed the following poster: ");
          Console.ForegroundColor = ConsoleColor.Green;     
          Console.Write("(Your reputation has increased by 10)\n\n"); //TO BE DELETED LATER
          HasPoster = true;
          reputation += 10;  //ADDS REPUTATION FOR PLACING A POSTER
          break;
        case ConsoleKey.N:
          view = false;
          break;
        default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Wrong letter input!");
          view=false;
          break;
      }
      Console.ResetColor();
    }
    else{
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("You have already placed a poster:\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Would you like to see the poster again? [Press 'Y' for yes and 'N' for no]");
      switch(Console.ReadKey(true).Key){
        case ConsoleKey.Y:
          view=true;
          break;
        case ConsoleKey.N:
          view = false;
          break;
        default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Wrong letter input!");
          view=false;
          break;
      }
      Console.ResetColor();
    }
    if(view){
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine($"\t╔{new String('═', maxlenght)}╗");
      Console.WriteLine($"\t║ ●{new String(' ', maxlenght-4)}● ║");
      Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
      switch(Name){

        case "Afr_Sav": //AFRICA - SAVANNAH POSTER
          string title = "PROTECT OUR WILDLIFE: POACHERS' TACTICS AND HOW TO HELP";
          string subtitle = "Keep an eye out for these methods used by poachers";
          string p1 = "1. Snares and Traps - Poachers use hidden snare traps to trap young";
          string p2 = "animals like lion cubs. Watch for these near animal paths.";
          string p3 = "2. Chasing with Jeeps - Poachers exhaust herds, such as zebras, by";
          string p4 = "chasing them with vehicles.";
          string p5 = "Report any suspicious vehicles driving recklessly in the savannah.";
          string p6 = "3. Tranquilizing Rhinos - Rhinos are being hunted for their horns. ";
          string p7 = "Poachers use tranquilizers to put them to sleep before cutting off their horns.";
          string p8 = "Act quickly if you see someone use darting equipment.";
          string endnote1 = "Make a difference! Report suspicious activity, remove traps,";
          string endnote2 = "and protect the savannah's wildlife!";
          PrintPosterline(title);PrintPosterline(subtitle);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
          PrintPosterline(p1);PrintPosterline(p2);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
          PrintPosterline(p3);PrintPosterline(p4);PrintPosterline(p5);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
          PrintPosterline(p6);PrintPosterline(p7);PrintPosterline(p8);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║");
          PrintPosterline(endnote1);PrintPosterline(endnote2);
          break;

        case "Asia_Grass": //ASIA - GRASSLAND POSTER
          title = "Welcome to the beautiful lands of the asian grasslands!";
          subtitle = "The local villigers would like to inform you of the following problem:";
          p1 = "The Indian Rhinoceros is the second largest extant species of rhinoceros.";
          p2 = " They are being poached for their horns, as trophies and because certain";
          p3 = "cultures believe they have medicinal properties. Due to loss of habitat";
          p4 = "and deforestation, they are especially vulnerable to poachers"; 
          endnote1 = "If you notice any wounded rhinos or signs of poaching, alert the authorities";
          endnote2 = "as soon as possible!";
          PrintPosterline(title);PrintPosterline(subtitle);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
          PrintPosterline(p1);PrintPosterline(p2);PrintPosterline(p3);PrintPosterline(p4);
          PrintPosterline(endnote1);PrintPosterline(endnote2);
          break;

        case "Asia_Swamp": //ASIA - SWAMP POSTER
          title = "Welcome to the beautiful lands of the asian swamps";
          subtitle = "The Asian Rangers Community would like you to know the following:";
          p1 = "The Tiger has a powerful, muscular body with a large head and paws, a long tail";
          p2 = "and orange fur with black, mostly vertical stripes. It is being poached for trophies,";
          p3 = "as well as superstitious beliefs. Another danger for the tiger is the illegal pet trade,";
          p4 = "for which young cubs are captured.";
          endnote1 = "If you notice any wounded tigers or signs of poaching, alert the authorities"; 
          endnote2 = "as soon as possible!";
          PrintPosterline(title);PrintPosterline(subtitle);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
          PrintPosterline(p1);PrintPosterline(p2);PrintPosterline(p3);PrintPosterline(p4);
          PrintPosterline(endnote1);PrintPosterline(endnote2);
          break;

        case "Afr_Grass": //AFRICA - GRASSLANDS POSTER
          title = "We, the Rangers-Union, welcome you to the Grasslands! These sacred lands are the home";
          string title2 = "to special wildlife, including the zebra. In order to protect this ecosystem, we all";
          string title3 = "have to follow certain rules that intend to keep the natural heritage as it is.";
          subtitle = "GRASSLAND RULES:";
          p1 = "1. NO POACHING - The hunting of zebras is strictly banned.    ";
          p2 = "Zebras are a protected species. Violators will face legal consequences.";
          p3 = "2. STAY ON MADE PATHS - Walking off road can harm plants and  "; 
          p4 = "disturb the habitats of animals.                              ";
          p5 = "3. NO LITTERING - Everything you took here with you should be ";
          p6 = "taken back with you. Waste can harm the animals and the land.";
          p7 = "4. NO FIRES WHERE THEY ARE NOT ALLOWED - Grasslands are really";
          p8 = "susceptible to fire. If used wrongly, major fires";
          string p9 = "could break out and harm the land.";
          string p10 = "5. RESPECT THE SPACE OF ANIMALS - Always keep a safe distance ";
          string p11 = "from the animals. It will ensure the safety of the animals and yourself.";
          string subtitle2 = "WHY IS IT OUR MISSION TO PROTECT THE ZEBRAS?";
          endnote1 = "Zebras are an important part of the grassland’s ecosystem, as are all animals.";
          endnote2 = "The Zebras part of the ecosystem is to control the plant growth, maintain the health of";
          string endnote3 = "the grassland, and support varied species, for example, as food. They also attract";
          string endnote4 = "a lot of tourists, which helps the local economy grow. Most importantly, they are an";
          string endnote5 = "endangered species. Protecting them will preserve biodiversity and keep the grassland as it is.";
          PrintPosterline(title);PrintPosterline(title2);PrintPosterline(title3);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║");
          PrintPosterline(subtitle);PrintPosterline(p1);PrintPosterline(p2);
          PrintPosterline(p3);PrintPosterline(p4);PrintPosterline(p5);PrintPosterline(p6);
          PrintPosterline(p7);PrintPosterline(p8);PrintPosterline(p9);PrintPosterline(p10);PrintPosterline(p11);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║");
          PrintPosterline(subtitle2);PrintPosterline(endnote1);PrintPosterline(endnote2);PrintPosterline(endnote3);
          PrintPosterline(endnote4);PrintPosterline(endnote5);
          break;

        case "Afr_For": //AFRICA - FOREST POSTER
          title = "We, the Rangers-Union, welcome you to the Forest! The forest is a sacred place and home";
          title2 = "to many animals, including the elephant. In order to protect this ecosystem, we all";
          title3 = "have to follow certain rules that intend to keep the natural heritage as it is.";
          subtitle = "FOREST RULES:";
          p1 = "1. NO POACHING - The hunting of zebras is strictly banned.    ";
          p2 = "Elephants are a protected species. Violators will face legal consequences.";
          p3 = "2. STAY ON MADE PATHS - Walking off road can harm plants and  "; 
          p4 = "disturb the habitats of animals.                              ";
          p5 = "3. NO LITTERING - Everything you took here with you should be ";
          p6 = "taken back with you. Waste can harm the animals and the land.";
          p7 = "4. NO FIRES WHERE THEY ARE NOT ALLOWED - Fires are only allowed";
          p8 = "at certain places. The forest is highly flammable. That is why ";
          p9 = "campfires in the wrong places can lead to great destruction.  ";
          p10 = "5. RESPECT THE SPACE OF ANIMALS - Always keep a safe distance ";
          p11 = "from the animals. It will ensure the safety of the animals and yourself.";
          subtitle2 = "WHY IS IT OUR MISSION TO PROTECT THE ELEPHANTS?";
          endnote1 = "Elephants are an important part of the forest's ecosystem. The elephant's part in the";
          endnote2 = "ecosystem is to shape the forest by creating pathways with their big bodies, spreading";
          endnote3 = "seeds, and supporting plant growth. With this, they support countless other species in";
          endnote4 = "the forest. They also attract a lot of tourists, which helps the local economy grow. ";
          endnote5 = "Most importantly, they are an endangered species. Protecting them will preserve the  ";
          string endnote6 = "biodiversity and keep the forest as it is.";
          PrintPosterline(title);PrintPosterline(title2);PrintPosterline(title3);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║");
          PrintPosterline(subtitle);PrintPosterline(p1);PrintPosterline(p2);
          PrintPosterline(p3);PrintPosterline(p4);PrintPosterline(p5);PrintPosterline(p6);
          PrintPosterline(p7);PrintPosterline(p8);PrintPosterline(p9);PrintPosterline(p10);PrintPosterline(p11);
          Console.WriteLine($"\t║{new String(' ', maxlenght)}║");Console.WriteLine($"\t║{new String(' ', maxlenght)}║");
          PrintPosterline(subtitle2);PrintPosterline(endnote1);PrintPosterline(endnote2);PrintPosterline(endnote3);
          PrintPosterline(endnote4);PrintPosterline(endnote5);PrintPosterline(endnote6);
          break;
      }     
      Console.WriteLine($"\t║{new String(' ', maxlenght)}║"); 
      Console.WriteLine($"\t║ ●{new String(' ', maxlenght-4)}● ║");
      Console.WriteLine($"\t╚{new String('═', maxlenght)}╝");
      Console.ResetColor();
    }
  }

  private void PrintPosterline(string line, int mlenght = 99){
    if(line.Length % 2 == 0)
      Console.WriteLine($"\t║{new String(' ',(mlenght-line.Length)/2)}{line}{new String(' ',(mlenght-line.Length)/2)} ║");
    else 
      Console.WriteLine($"\t║{new String(' ',(mlenght-line.Length)/2)}{line}{new String(' ',(mlenght-line.Length)/2)}║");
  }
}