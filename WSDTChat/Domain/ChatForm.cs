using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSDTChat.Domain
{
    public class ChatForm
    {
        [Required(ErrorMessage = "Nothing to say?")]
        public string MessageInput { get; set; }
        [Required]
        public ChatUser CurrentUser { get; set; } = new ChatUser();
    }
}
