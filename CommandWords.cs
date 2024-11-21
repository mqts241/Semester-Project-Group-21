using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul
{
    public class CommandWords
    {
<<<<<<< HEAD
        public List<string> ValidCommands { get; } = new List<string> { "north", "east", "south", "west", "look", "back", "commands", "cmds", "quit", "take", "throw", "give", "inventory", "view", "inv", "poster", "talk"};
=======
        public List<string> ValidCommands { get; } = new List<string> { "north", "east", "south", "west", "look", "back", "commands", "cmds", "quit", "take", "throw", "give", "inventory", "view", "use", "inv", "poster", "talk"};
>>>>>>> cristi-unfinalized



        public bool IsValidCommand(string command)
        {
            return ValidCommands.Contains(command);
        }
    }

}