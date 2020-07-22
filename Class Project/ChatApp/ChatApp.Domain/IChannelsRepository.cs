using System;
using System.Collections.Generic;
using System.Text;
using ChatApp.Domain.Models;
namespace ChatApp.Domain
{
    public interface IChannelsRepository
    {
        IEnumerable<Channel> GetAllChannels();

        IEnumerable<Channel> GetChannelsBySearchParameter(string searchParameter);

        IEnumerable<Channel> GetChannelsForAutocomplete(string searchParameter);
    }
}
