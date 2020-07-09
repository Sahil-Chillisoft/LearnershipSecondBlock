using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain.Models
{
    public class ChannelMembers
    {
        public int ChannelId { get; set; }
        public int UserId { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
