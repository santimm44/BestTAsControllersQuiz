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
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItService _ReverseItService;

        public ReverseItController(ReverseItService reverseItService)
        {
            _ReverseItService = reverseItService;
        }

        [HttpPost]
        [Route("ReverseIt/{userInput}")]
        public string GetReverseIt(string userInput)
        {
            return _ReverseItService.ReverseItMethod(userInput);
        }
    }
}