using System;
using System.Collections.Generic;
using System.Linq;
namespace Sharpic_easy.Models
{
    public class Reply
    {
        public Reply() { }
        public Reply (int id, string? replyType, string? replyMessage)
        {
            Id = id;
            ReplyType = replyType;
            ReplyMessage = replyMessage;
        }

        public int Id { get; set; }
        public string? ReplyType { get; set; }
        public string? ReplyMessage { get; set; }
    }
}
