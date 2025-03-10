﻿using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine("Sending Message.....");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
