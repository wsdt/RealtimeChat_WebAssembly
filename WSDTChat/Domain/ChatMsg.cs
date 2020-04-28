using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSDTChat.Domain
{
    public class ChatMsg
    {
        public ChatUser User { get; set; }
        public List<string> Messages { get; set; }

        public ChatMsg(ChatUser User, List<string> Messages)
        {
            this.User = User;
            this.Messages = Messages;
        }
    }
}
