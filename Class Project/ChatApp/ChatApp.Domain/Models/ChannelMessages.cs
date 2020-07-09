using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain.Models
{
    public class ChannelMessages
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public int AuthorUserId { get; set; }
        public string Message { get; set; }
        public DateTime DateTimeOfMessage { get; set; }
    }
}
