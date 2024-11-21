● UPDATE LOG - 19.11.2024 - by Cristi ● 
=
> [!IMPORTANT]
> The code has the following known things that do not work and are in progress of being fixed or added
> 1. The "talk" command for the NPCs are not added yet
> 2. The "poster" command NOW WORKS completely

**Things added:**
- NPC.cs file
- ItemUse.cs file
- Choice.cs file
- Commands that use the new code from the previously mentioned files

**Other small details that will be modified for aesthetic purposes:**
- the "look" command will have its own function
- parts of the "choice" will be moved from the Game.cs file later


● UPDATE LOG - 13.11.2024 - by Cristi ●
=
## New things added:
  * Reputation level for the player to gain/lose during the game (which will output at the end different messages depending on the reputation score; more details later)

  * Regions (each room can be apart of a region) - it helps us with poster handling and it's easier to control it on a bigger area, rather than by rooms.
  The following list shows the regions and their names as given in the game:
    * Africa HUB - "Afr"
    * Africa Mountain Forest - "Afr_Mf"
    * Africa Grassland - "Afr_Grass"
    * Africa Forest - "Afr_For"
    * Africa Savannah - "Afr_Sav"
    * Asia HUB - "Asia"
    * Asia Grassland - "Asia_Grass"
    * Asia Swamp - "Asia_Swamp"
    * Asia Jungle - "Asia_Jungle"
    * Asia Mountains - "Asia_Mount" (THIS WILL BE ADDED WHEN(or if) THE AREA IS CREATED (Mihnea is on it))

  * Printer (this is found in a new file called "Printer.cs"). 
  Since we need to maintain an easy to read code in the Game.cs file all of the text should be added in the printer to be easy accessible via a simple void function that will not affect the readability of our files. This way we can reduce the amount of text all around our files and it is easier to find, add and access them in one single file dedicated to them.

  * "poster" command - depending of the area you are in, you can call the command which will print out the question if you want to put up a poster or not. If the player selects the 'y' key(on the keyboard) as their answer we will print out the poster which has a build function that makes the text centered so that we can see clearly the message. The command that prints the poster is located in the Region.cs file.
  Current areas that have a poster implemented:
    * => Savannah (Afr_Sav)
    * => Grasslands (Afr_Grass)
    * => Forest (Afr_For)
    * => Grasslands (Asia_Grass)
    * => Swamp (Asia_Swamp)
  (TO BE ADDED THE JUNGLE AND THE MOUNTAIN FOREST)
  
  * Redone the "quit" command, which prints out an EPIC text at the end and before the player can continue it is asked to press 'Enter' for the stats to show up; (stats can be implemented later if we find the time); So far, it will print out a message depending on the reputation score collected during the game

## Modified:
  * Implemented the new modifications as Rita mentioned, meaning that the commands have a specific function that is called from the parent class:</br></br>
   **1. In the Inventory class we now have more functions to be able to access them easy**
      * SeeInventory - returns all items in the inventory; 
      * IsFull/IsEmpty - checks wheter the inventory is full/empty;
      * AddItem/RemoveItem - when called adds/removes an item from the inventory NOTE: You need to actually add in the function the item which you want to add/remove;
      * FindItemInInv - Checks using a string (the input our player gives) to find an item in the inventory that has the same name as the string provided;
      * Take/Throw - the commands previously found in Game.cs have been moved to Inventory.cs since it depends on our inventory for it to work.
      
    **2. The Room class has received similar changes as the Inventory class**
      * AddItem/RemoveItem - when called adds/removes an item from the room NOTE: You need to actually add in the function the item which you want to add/remove;
      * IsEmpty - since we don't have a maximum amount of item spaces in a room we only need to check if there are no items in the room, in case a player wants to take an item from a room that does not have any items;
      * FindItemInRoom - Checks using a string (the input our player gives) to find an item in the room that has the same name as the string provided;
      * View (THIS CAN STAY OR NOT WE WILL SEE LATER) - Prints out every item that the room we are in has.

  * Updated the variables to "private" for all the values that should not be accessed outside thier specific class. This includes most values apart from the commands (because we still need to access them since the players input is modified in-game)


> [!IMPORTANT]
> **OTHER NOTES**
>  * (To be modified LATER) The "give" command will be added to the NPC class when the NPC update comes.
>  *  if you want to change the name of the region please make sure you change the region name to every room that is part of it also change the switch case in the 'SetPoster' function.
