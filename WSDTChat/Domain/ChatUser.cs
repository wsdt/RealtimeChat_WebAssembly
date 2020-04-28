using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSDTChat.Domain
{
    public class ChatUser
    {
        [Required(ErrorMessage = "Please provide an E-Mail")]
        [EmailAddress(ErrorMessage = "That doesn't look like an E-Mail address.")]
        public string EMail { get; set; }
        public bool IsGuest { get; set; } = true;

        public ChatUser(string EMail, bool IsGuest)
        {
            this.EMail = EMail;
            this.IsGuest = IsGuest;
        }

        public ChatUser() { }

        public override bool Equals(object obj)
        {
            ChatUser cu = obj as ChatUser;
            if ((object)cu == null) return false;

            return (EMail.Equals(cu.EMail) && IsGuest.Equals(cu.IsGuest));
        }

        public override int GetHashCode()
        {
            return EMail.GetHashCode() ^ IsGuest.GetHashCode();
        }
    }
}
