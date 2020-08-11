using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command { Id = 1, HowTo = "Do some thing 1", Line = "some more examples 1", Platform = "Some Paltform 1" },
        new Command { Id = 2, HowTo = "Do some thing 2", Line = "some more examples 2", Platform = "Some Paltform 2" },
        new Command { Id = 3, HowTo = "Do some thing 3", Line = "some more examples 3", Platform = "Some Paltform 3" },
        new Command { Id = 4, HowTo = "Do some thing 4", Line = "some more examples 4", Platform = "Some Paltform 4" },
      };

      return commands;
    }

    public Command GetCommandById(int Id)
    {
      return new Command { Id = 3, HowTo = "Do some thing", Line = "some more examples", Platform = "Some Paltform" };
    }
  }
}