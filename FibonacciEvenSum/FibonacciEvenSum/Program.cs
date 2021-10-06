using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coding Challenge 2
            //FibonacciEvenSum
            //Each new term in the Fibonacci sequence is generated
            //by adding the previous two terms.By starting with
            //1 and 2, the first 10 terms will be:

            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            //variables to hold the first number, second number, next number in sequence and to hold the total
            int firstNumber = 0, secondNumber = 1, nextNumber, total = 0;
            //we start with first number 0 and second number 1 and add them together to start the nextnumber to get started
            nextNumber = firstNumber + secondNumber;
            //loop through the nextnumber as long as it is below 4 million
            for (int i = 2; nextNumber < 4000000; i++)
            {
                //check to see if it is a even number
                if (nextNumber % 2 == 0)
                {
                    //even number so write it to the screen
                    Console.WriteLine($"Even Numbers: {nextNumber}");
                    //even number so add to the total
                    total += nextNumber;
                }
                //take the firstnumber and add it to the secondnumber
                firstNumber = secondNumber;
                //take the nextnumber stored and start it as the secondnumber
                secondNumber = nextNumber;
                //now take the firstnumber updated above and add it to the second number updated above to get our next number
                nextNumber = firstNumber + secondNumber;
            }

            //write the total out to the screen
            Console.WriteLine($"\n\nGrand Total: {total}");
        }
    }
}
