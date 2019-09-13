using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Please enter an number value which is between 1 and 100");
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0 || number > 100)
                    {
                        Console.WriteLine("The number value should lie between 1 and 100");
                    }
                    else
                    {
                        for (int a = 1; a < 11; a++)
                        {
                            Console.WriteLine(" You have entered " + number + "This is the integer(number) value in the loop: " + a.ToString());
                        }

                    }
                    Console.ReadKey();

                }
            }
            catch
            {
                Console.WriteLine("For this program to run, please enter an integer(number) value");
            }
                
        }
    }
}
