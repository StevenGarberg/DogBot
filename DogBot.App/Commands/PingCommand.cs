﻿using System.Threading.Tasks;
using Discord.Commands;

namespace DogBot.App.Commands
{
    public class PingCommand : CommandBase
    {
        [Command("ping")]
        public async Task HandleCommandAsync()
        {
            await ReplyAsync("I am pinging the server.");
        }
    }
}