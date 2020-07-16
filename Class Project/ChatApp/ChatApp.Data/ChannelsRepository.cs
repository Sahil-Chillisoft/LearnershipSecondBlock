using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatApp.Domain;
using ChatApp.Domain.Models;

namespace ChatApp.Data
{
    public class ChannelsRepository : IChannelsRepository
    {
        private readonly ChatAppDatabaseContext _context;

        public ChannelsRepository(ChatAppDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Channel> GetAllChannels()
        {
            return _context.Channel.ToList();
        }

        public IEnumerable<Channel> GetChannelsBySearchParameter(string searchParameter)
        {
            throw new NotImplementedException();
        }
    }
}
