using System;

namespace D2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input request
            Console.WriteLine("Enter an Integer Value between 1 and 100!");

            try
            {
                //read input
                string input = Console.ReadLine();

                //parse input
                int value = int.Parse(input);

                if ((value > 0) && (value < 101))
                {
                    Console.WriteLine("Executing...");

                    //loop output
                    for (int i = 1; i<= value; i++)
                    {
                        Console.WriteLine("You have entered " + value + ". This is the current integer value in the loop: " + i);
                    }
                }
            }

            catch
            {
                Console.WriteLine("Error, value entered is not an integer value. Please restart program and try again...");
            }
        }
    }
}
