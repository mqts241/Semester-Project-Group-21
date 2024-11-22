﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul
{
    public class CommandWords
    {
        public List<string> ValidCommands { get; } = new List<string> { "north", "east", "south", "west", "look", "back", "commands", "cmds", "quit", "take", "throw", "give", "inventory", "view", "inv", "chance"};



        public bool IsValidCommand(string command)
        {
            return ValidCommands.Contains(command);
        }
    }

}
