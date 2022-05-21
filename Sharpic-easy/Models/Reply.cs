using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpic_easy.Models
{
    internal class Reply
    {
        internal Reply (int id, string? replyType, string? replyMessage)
        {
            Id = id;
            ReplyType = replyType;
            ReplyMessage = replyMessage;
        }

        internal int Id { get; set; }
        internal string? ReplyType { get; set; }
        internal string? ReplyMessage { get; set; }
    }
}
