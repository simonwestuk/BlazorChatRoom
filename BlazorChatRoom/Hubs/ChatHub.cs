using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorChatRoom.Hubs
{
    public class ChatHub : Hub
    {
        public static string HubPath = "/chatroom";

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} Connected!");

            return base.OnConnectedAsync(); //Connected to the main hub
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            Console.WriteLine($"{Context.ConnectionId} Disconnected!");
            await base.OnDisconnectedAsync(exception); //Disconnected from the main hub
        }
    }
}
