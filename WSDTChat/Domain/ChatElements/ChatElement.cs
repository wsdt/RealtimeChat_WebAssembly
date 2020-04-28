using System;
using System.Collections.Generic;
using System.Globalization;

namespace WSDTChat.Domain.ChatElements
{
    public abstract class ChatElement
    {
        public DateTime ReceivedTimestamp { get; set; } = DateTime.Now;
        public ChatUser User { get; set; }
        public List<string> Messages { get; set; }

        /* String representation of time difference for UX. */
        public string GetTimeDifference()
        {
            TimeSpan diff = DateTime.Now - ReceivedTimestamp;
            if (diff.Days > 0) return $"{diff.Days} days ago";
            if (diff.Hours > 0) return $"{diff.Hours} hours ago";
            if (diff.Minutes > 0) return $"{diff.Minutes} minutes ago";
            return "A few seconds ago";
        }

        public ChatElement(ChatUser User, List<string> Messages)
        {
            this.User = User;
            this.Messages = Messages;
        }


    }
}
