using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WSDTChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync(HubEvent.IPublic.RECEIVE_MSG, user, message);
        }
    }
}
