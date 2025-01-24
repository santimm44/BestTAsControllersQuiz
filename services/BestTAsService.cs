using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestTAsControllersQuiz.services
{
    public class BestTAsService
    {
        public string AddTwoNumbersMethod(string firstNum, string secondNum)
        {
            int firstNumber, secondNumber;
            bool testFirstValue = int.TryParse(firstNum, out firstNumber);
            bool testSecondValue = int. TryParse(secondNum, out secondNumber);

            if (testFirstValue == false || testSecondValue == false)
            {
                return "Sorry, one of your values are not a number";
            }
            
            int sum = firstNumber + secondNumber;
            return $"{firstNum} and {secondNum} is equal to {sum}";
        }
    }
}