/*
Author: George Ledbury
Date: Oct. 09, 2016
CTEC 135: Microsoft Software Development with C#

<Module # 2, Programming Assignment # 1 Part 2, Problem # 2: Iteration Constructs>

Region 1: print the digits 1-5 using a for loop.
Region 2: print the digits 1-5 using a while loop.
Region 3: print the digits 1-5 using a do/while loop.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region print the numbers 1-5 with a for loop structures
            Console.WriteLine("print the numbers 1-5 using a for loop with a space betweeneach number.");
            Console.WriteLine();
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region print the numbers 1-5 using a while loop
            Console.WriteLine("print the numbers 1-5 using a while loop with a space between each number.");
            Console.WriteLine();
            int count = 1;
            while (count < 6)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region print the numbers 1-5 using a do/while loop
            Console.WriteLine("print the numbers 1-5 using a do/while loop with a space between each number.");
            Console.WriteLine();
            int number = 1;
            do
            {
                Console.Write(number + " ");
                number++;
            } while (number < 6);
            Console.WriteLine();
            #endregion
        }
    }
}
