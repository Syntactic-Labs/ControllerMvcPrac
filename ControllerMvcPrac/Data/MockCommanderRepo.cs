using ControllerMvcPrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerMvcPrac.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>()
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and Pan" },
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get knife", Platform = "Cutting Board" },
                new Command { Id = 2, HowTo = "Eat Grapes", Line = "Wash Grapes", Platform = "Bowl" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and Pan" };
        }
    }
}
