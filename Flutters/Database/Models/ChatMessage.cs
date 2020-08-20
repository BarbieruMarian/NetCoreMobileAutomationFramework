using System;
using System.Collections.Generic;
using System.Text;

namespace Flutters.Database.Models
{
    public class ChatMessage
    {
        public bool IsSeen { get; set; }
        public string Message { get; set; }
        public string Reciever { get; set; }
        public string Sender { get; set; }
        public string Timestamp { get; set; }
        public string Type { get; set; }

    }
}
