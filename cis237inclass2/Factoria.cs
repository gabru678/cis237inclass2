using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factoria
    {

        public Factoria()
        {
            //Prompt the user for a number to compute
            Console.WriteLine("Input a number to calculate the factorial of: \n");

            try
            {
                //Get the number to performfactoraial on from the user
                int factorialInt = Convert.ToInt32(Console.ReadLine());

                //Output what the problem to solve is
                Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");

                //Solve the problem and put in a answerInt
                int answerInt = Calculate(factorialInt);

                // Output the answer to the screen
                Console.WriteLine("\n The answer is: " + answerInt + Environment.NewLine);
            }

            catch
            {
                Console.WriteLine("You didnt enter a valid integer");
            }

       }

        private int Calculate(int number)
        {
            //If the number is 1;, we have reached the BASE CASE.  We ant our
            // execution to change and start returning from the method calls
           // If we did not have this Base Case, we would continue forever until we used up all of the memory in the stack, causing a stack overflow
            if (number == 1)
            {
                return 1;
                //Return number; Also works
            }

            // Since we are not at the Base Case of the number equaling 1,
            // we want to call this methid that we are in another time and send in the number -1
            // as the parameter to the recursive call
            return number * Calculate(number - 1);
        }
    }
}
