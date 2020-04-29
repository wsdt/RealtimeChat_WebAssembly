using Microsoft.AspNetCore.SignalR;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using WSDTChat.Domain;

namespace WSDTChat.Hubs
{
    public class ChatHub : Hub
    {

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public override async Task OnConnectedAsync() => Console.WriteLine($"New connection from {Context.ConnectionId} at {DateTime.Now}");

        public async Task SystemMsg(string message, MsgPriority priority)
        {
            await Clients.Others.SendAsync(HubEvent.IPublic.SYSTEM_MSG, message, priority);
        }

        public async Task BroadcastMsg(string user, string message)
        {
            await Clients.All.SendAsync(HubEvent.IPublic.RECEIVE_MSG, user, message);
        }
    }
}
