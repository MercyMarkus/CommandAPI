﻿using CommandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById();
        void UpdateCommand(Command cmd);
        void CreateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
