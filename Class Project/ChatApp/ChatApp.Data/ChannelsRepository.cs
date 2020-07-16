using System;
using System.Collections.Generic;
using System.Text;
using ChatApp.Domain;
using ChatApp.Domain.Models;

namespace ChatApp.Data
{
    public class ChannelsRepository : IChannelsRepository
    {
        public IEnumerable<Channel> GetAllChannels()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Channel> GetChannelsBySearchParameter(string searchParameter)
        {
            throw new NotImplementedException();
        }
    }
}
