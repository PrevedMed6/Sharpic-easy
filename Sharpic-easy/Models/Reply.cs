using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpic_easy.Models
{
    public class Reply
    {
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
