using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Web.Api
{
    [Route("api/Channels")]
    [ApiController]
    public class ChannelsController : ControllerBase
    {
        private readonly IChannelsRepository _channelRepository;

        public ChannelsController(IChannelsRepository channelRepository)
        {
            _channelRepository = channelRepository;
        }

        [HttpGet]
        public ActionResult GetAllChannels()
        {
            var channelList = _channelRepository.GetAllChannels();

            if (channelList == null)
                return NotFound();

            return new JsonResult(new { data = channelList });
        }

        [HttpGet("GetChannelsForAutocomplete")]
        public ActionResult GetChannelsForAutocomplete([FromQuery] string searchParameter)
        {
            var channelList = _channelRepository.GetChannelsForAutocomplete(searchParameter);
            return new JsonResult(channelList);
        }
    }
}
