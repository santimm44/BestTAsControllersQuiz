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
    public class BestTAsController : ControllerBase
    {
        
        private readonly BestTAsService _BestTAsService;

        public BestTAsController(BestTAsService bestTAsService)
        {
            _BestTAsService = bestTAsService;
        }


        [HttpPost]
        [Route("AddTwoNumbers/{firstNum},{secondNum}")]
        public string AddTwoNumbers(string firstNum, string secondNum)
        {
            return _BestTAsService.AddTwoNumbersMethod(firstNum, secondNum);
        }
    }
}