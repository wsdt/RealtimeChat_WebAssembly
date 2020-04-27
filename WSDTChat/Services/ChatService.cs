using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSDTChat.Services
{

    public class ChatMsg
    {
        public string User { get; set; }
        public string Message { get; set; }

        public ChatMsg(string user, string message)
        {
            this.User = user;
            this.Message = message;
        }
    }

    public interface IChatService
    {
        public Task Send();
        public bool IsConnected();
        public string UserInput { get; set; }
        public string MessageInput { get; set; }
        public List<ChatMsg> Messages { get; set; }
        public HubConnection HubConnection { get; set; }

    }

    public class ChatService : IChatService
    {

        public HubConnection HubConnection { get; set; }
        private NavigationManager NavigationManager { get; set; }
        
        public string UserInput { get; set; }
        public string MessageInput { get; set; }
        public List<ChatMsg> Messages { get; set; }
        

        public ChatService(NavigationManager navigationManager)
        {
            this.NavigationManager = navigationManager;
            this.Messages = new List<ChatMsg>();
        }

        public Task Send()
        {
            var res = HubConnection.SendAsync("SendMessage", UserInput, MessageInput);
            MessageInput = "";
            return res;
        }

        public bool IsConnected()
        {
            return HubConnection.State == HubConnectionState.Connected;
        }



    }
}
