﻿using AnimeNotificationsBot.Api.Services.Commands;
using AnimeNotificationsBot.Api.Services.Commands.Anime;
using AnimeNotificationsBot.Api.Services.Commands.Base;
using AnimeNotificationsBot.Api.Services.Interfaces;
using AnimeNotificationsBot.BLL.Interfaces;

namespace AnimeNotificationsBot.Api.Services
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IUserService _userService;
        private readonly IBotSender _botSender;
        private readonly IAnimeService _animeService;

        public CommandFactory(IUserService userService, IBotSender botSender, IAnimeService animeService)
        {
            _userService = userService;
            _botSender = botSender;
            _animeService = animeService;
        }

        public ITelegramCommand CreateCallbackCommand(CallbackCommandArgs commandArgs)
        {
            var command = new CombiningCommand(new ITelegramCommand[]
            {
                new AnimeInfoCommand(commandArgs,_animeService,_botSender)
            });

            return new MainCallbackQueryCommand(commandArgs, command, _botSender);
        }

        public ITelegramCommand CreateMessageCommand(MessageCommandArgs commandArgs)
        {
            var command = new CombiningCommand(new ITelegramCommand[]
            {
                new StartCommand(commandArgs,_userService,_botSender),
                new HelpCommand(commandArgs,_botSender),
                new FindAnimeCommand(commandArgs,_animeService,_botSender),
                new FoundAnimeCommand(commandArgs,_animeService,_botSender),
            });

            return new MainMessageCommand(commandArgs, command, _botSender);
        }
    }
}