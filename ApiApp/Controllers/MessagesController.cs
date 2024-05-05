using DiDemoLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : Controller
    {
        private readonly IMessages _messages;

        public MessagesController(IMessages messages)
        {
            _messages = messages;
        }
        // GET: MessagesController
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _messages.sayHello(), _messages.sayGoodBye()};
        }

    }
}
