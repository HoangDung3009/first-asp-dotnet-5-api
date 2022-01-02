﻿using HoangDung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoangDung.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();


        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);

        void DeleteCommand(Command command);
    }
}
