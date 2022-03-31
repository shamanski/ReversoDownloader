﻿using ReversoConsole.Controller;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TgBot.BotCommands.Commands
{
    public class RemoveCommand : BotCommand
    {
        public override string Name { get; } = "/remove";
        private LearningController learningController;

        public RemoveCommand(ChatController chatController) : base(chatController)
        {
        }

        public async override Task<bool> Execute(ReversoConsole.DbModel.User user, Message message, params string[] param)
        {
            learningController = new LearningController(user);
            message.Text = $"Введите слово:";
            message.ReplyMarkup = null;
            await chat.ReplyMessage(message);
            return true;
        }

        public async override Task<bool> Next(ReversoConsole.DbModel.User user, Message message)
        {
            try
            {
                var word = learningController.Find(message.Text);
                if (learningController.RemoveWord(word) )
                     message.Text = $"Удалено {word}";
                else
                {
                    message.Text = $"Такого слова не найдено {word}";
                }
            }
            catch
            {
                message.Text = $"Ошибка связи с сервером. Попробуйте позже.";
                await chat.ReplyMessage(message);
                return false;
            }

            await chat.ReplyMessage(message);
            return false;
        }
    }
}
