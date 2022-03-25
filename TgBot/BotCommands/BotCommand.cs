﻿using ReversoConsole.DbModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TgBot.BotCommands
{
    public abstract class BotCommand
    {
        public abstract string Name { get; }

        public abstract Task<bool> Execute(ReversoConsole.DbModel.User user, Message message);


        public abstract Task<bool> Next(ReversoConsole.DbModel.User user, Message message);
    }
}
