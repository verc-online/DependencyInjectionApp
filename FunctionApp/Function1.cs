using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DiDemoLib;

namespace FunctionApp
{
    public  class Function1
    {
        private readonly IMessages _messages;

        public Function1(IMessages messages)
        {
            _messages = messages;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            
            return new OkObjectResult(new string[] { _messages.sayHello(), _messages.sayGoodBye() });
        }
    }
}
