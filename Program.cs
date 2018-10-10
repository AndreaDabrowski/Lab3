using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            //prompts user to set name and stores
            Console.WriteLine("Hello, please state your name: ");
            string userName = Console.ReadLine();
                     
            do
            {
                //prompts user to enter number and stores
                Console.WriteLine("Please enter a positive number between 1 and 100: ");
                int i = int.Parse(Console.ReadLine());

                //Verifies that number is within given range
                while (i <= 0 || i > 100)
                {
                    Console.WriteLine("This number must be above 0 and below 100, please try again:");
                    i = int.Parse(Console.ReadLine());
                }

                //checks if number is divisible by 2
                if (i % 2 == 0)
                {
                    //checks that number is between 1 and 25 and even
                    if (i <= 25 && i >= 2)
                    {
                        Console.WriteLine("{0}, {1} is even and less than 25.", userName, i);
                    }
                    //when number is greater than 25, but even
                    else
                    {
                        Console.WriteLine("{0}, {1} is even.", userName, i);
                    }

                }
                //all other numbers are odd
                else
                {
                    Console.WriteLine("{0}, {1} is odd.", userName, i);
                }
                //prompts to try again
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to try again? (y/n)");
                response = Console.ReadLine().ToLower();
            }
            //only while next response is Y or y, it will loop through again - otherwise exit
            while (response == "y");
            
            //prompts user to exit only with n or N
            if (response == "n")
            {
               Console.WriteLine("Press any key to exit...");
               Console.ReadLine();
                   
            }
            //only y Y n N response allowed, prompts to try again
            else
            {
                    Console.WriteLine("Type a vaild response (y/n): ");
                    Console.ReadLine();
            }

            
        }
    }
}

