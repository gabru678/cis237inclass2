using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! \n Please enter the program you would like to use:" +
                                "\n 1. for Factorials"+
                                "\n 2. for Towers of Hanoi");
            String userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1" :
                    Factoria factorial = new Factoria();
                    break;

                case "2" :
                    Console.WriteLine("Enter the number of disks \n 'Hint: enter 5 or lower'");
                    userInput = Console.ReadLine();
                    try
                    {
                        //Do Hanoi Here
                        // Create a new instance of the hanoi class
                        Hanoi hanoi = new Hanoi();

                        //call the moveDisk metod to start solving the problems
                        hanoi.moveDisk(Int32.Parse(userInput), 'A', 'B', 'C');
                    }
                    catch
                    {
                        Console.WriteLine("You must enter an int");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input ya tart! \n :(");
                    break;
            }
            
        }
    }
}
