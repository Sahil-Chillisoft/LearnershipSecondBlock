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
        private readonly IChannelsRepository _repository;

        public ChannelsController(IChannelsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAllChannels()
        {
            var channelList = _repository.GetAllChannels();

            if (channelList == null)
                return NotFound();

            return new JsonResult(new { data = channelList });
        }
    }
}
