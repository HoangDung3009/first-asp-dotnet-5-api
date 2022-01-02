using HoangDung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangDung.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { id = 0, HowTo = "Make a teacup", Line = "Put teabag into tea", Platform = "Go to kitchen" },
                new Command { id = 1, HowTo = "Wash face", Line = "Take a towel", Platform = "Go to bathroom" },
                new Command { id = 2, HowTo = "Cut bread", Line = "get a knife", Platform = "Go to kitchen" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { id = 0, HowTo = "Make a teacup", Line = "Put teabag into tea", Platform = "Go to kitchen" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
    



    
