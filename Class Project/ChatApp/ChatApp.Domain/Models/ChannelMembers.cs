using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain.Models
{
    public class ChannelMembers
    {
        [Key]
        public int ChannelId { get; set; }
        [Key]
        public int UserId { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
