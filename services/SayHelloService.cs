using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllersQuiz.services
{
    public class SayHelloService
    {
        public string SayHelloMethod(string userName)
        {
            return $"Hello, {userName}";
        }
    }
}