using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSDTChat.Domain.ChatElements;

namespace WSDTChat.Domain
{
    public class ChatMsg : ChatElement
    {
        public ChatMsg(ChatUser User, List<string> Messages) : base(User, Messages)
        {
        }
    }
}
