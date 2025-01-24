using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestTAsControllersQuiz.services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllersQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloService _SayHelloService;
        public SayHelloController(SayHelloService sayHelloService)
        {
            _SayHelloService = sayHelloService;
        }

        [HttpPost]
        [Route("SayHello/{userName}")]
        public string GetSayHello(string userName)
        {
            return _SayHelloService.SayHelloMethod(userName);
        }
    }
}