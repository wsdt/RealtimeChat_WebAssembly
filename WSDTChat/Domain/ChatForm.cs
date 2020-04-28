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
        [StringLength(5000, MinimumLength = 1, ErrorMessage = "Your message has to contain at least 1 to 5000 chars at maximum.")]
        public string MessageInput { get; set; }
        [Required]
        public ChatUser CurrentUser { get; set; } = new ChatUser();
    }
}
