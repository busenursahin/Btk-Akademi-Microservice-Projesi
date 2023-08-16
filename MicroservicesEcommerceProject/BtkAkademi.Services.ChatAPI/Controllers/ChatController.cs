using BtkAkademi.Services.ChatAPI.Hubs;
using BtkAkademi.Services.ChatAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;

namespace BtkAkademi.Services.ChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _chatHub;
        public ChatController(IHubContext<ChatHub> chatHub)
        {
            _chatHub = chatHub;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Message message)
        {
            //same bussines rules
            _chatHub.Clients.All.SendAsync("customerchat", message);

            return Accepted();
        }
    }
}
