using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllersQuiz.services
{
    public class ReverseItService
    {

        public string ReverseItMethod(string userInput)
        {
            string reversedOutput = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversedOutput += userInput[i];

            }
            return reversedOutput;
        }
    }
}