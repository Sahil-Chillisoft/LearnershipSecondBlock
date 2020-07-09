using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public int AuthorUserId { get; set; }
        public int RecipientUserId { get; set; }
        public string Message { get; set; }
        public DateTime DateTimeOfMessage { get; set; }
    }
}
