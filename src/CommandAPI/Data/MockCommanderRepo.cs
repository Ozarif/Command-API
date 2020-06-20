using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=1,HowTo="How to use Command 1",Line="Command Line for Command 1",Platform="Platform for Command 1"},
                new Command{Id=2,HowTo="How to use Command 2",Line="Command Line for Command 2",Platform="Platform for Command 2"},
                new Command{Id=3,HowTo="How to use Command 3",Line="Command Line for Command 3",Platform="Platform for Command 3"}
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id=0,HowTo="How to use Command 0",Line="Command Line for Command 0",Platform="Platform for Command 0"};
        }
    }
}