/*
Author: George Ledbury
Date: Oct. 09, 2016
CTEC 135: Microsoft Software Development with C#

<Module # 2, Programming Assignment # 1 Part 2, Problem # 3: Decision Construct


Region 1: use for loops to decide on action based on conditions
Region 2: same problem, but use switch statements insted of for loops.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decision_constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: for loops to make action decisions based on conditions
            /* each for loop determines the conditions of the printer */
            for (int prints = 0; prints < 2; prints++)
            {
                for (int flashingLight = 0; flashingLight < 2; flashingLight++)
                {
                    for (int printerRecognized = 0; printerRecognized < 2; printerRecognized++)
                    {
                        /* below is the decision constructs to determine the action needed */
                        if (prints == 0 && flashingLight == 0 && printerRecognized == 0) 
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("...Printer prints: NO");
                            Console.WriteLine("...Red Light Flashing: NO"); 
                            Console.WriteLine("...Printer Recognized by Computer: NO");
                            Console.WriteLine();
                            Console.WriteLine("Actions to Take:");
                            powerCable();
                            printerCable();
                            printerSoftware();
                            Console.WriteLine("---------------------------------------------------------------------------------");
                        }
                        if (prints == 0 && flashingLight == 0 && printerRecognized == 1)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("...Printer prints: NO"); 
                            Console.WriteLine("...Red Light Flashing: NO"); 
                            Console.WriteLine("...Printer Recognized by Computer: YES");
                            Console.WriteLine("Actions to Take:");
                            paper();
                            Console.WriteLine("----------------------------------------------------------------------------------");
                        }
                        if (prints == 0 && flashingLight == 1 && printerRecognized == 1)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("Printer prints: NO"); 
                            Console.WriteLine("Red Light Flashing: YES"); 
                            Console.WriteLine("Printer Recognized by Computer: YES");
                            Console.WriteLine("Actions to Take:");
                            ink();
                            paper();
                            Console.WriteLine("-----------------------------------------------------------------------------------");
                        }
                        if (prints == 1 && flashingLight == 1 && printerRecognized == 1)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("Printer prints: YES"); 
                            Console.WriteLine("Red Light Flashing: YES"); 
                            Console.WriteLine("Printer Recognized by Computer: YES");
                            Console.WriteLine("Actions to Take:");
                            ink();
                            Console.WriteLine("------------------------------------------------------------------------------------");
                        }
                        if (prints == 1 && flashingLight == 0 && printerRecognized == 0)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("Printer prints: YES"); 
                            Console.WriteLine("Red Light Flashing: NO"); 
                            Console.WriteLine("Printer Recognized by Computer: NO");
                            Console.WriteLine("Actions to Take:");
                            printerSoftware();
                            Console.WriteLine("-------------------------------------------------------------------------------------");
                        }
                        if (prints == 1 && flashingLight == 1 && printerRecognized == 0)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("Printer prints: YES"); 
                            Console.WriteLine("Red Light Flashing: YES"); 
                            Console.WriteLine("Printer Recognized by Computer: NO");
                            Console.WriteLine("Actions to Take:");
                            printerSoftware();
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                        }
                        if (prints == 1 && flashingLight == 0 && printerRecognized == 1)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("Printer prints: YES"); 
                            Console.WriteLine("Red Light Flashing: NO"); 
                            Console.WriteLine("Printer Recognized by Computer: YES");
                            Console.WriteLine("Actions to Take:");
                            Console.WriteLine("*** No action needed!");
                            Console.WriteLine("---------------------------------------------------------------------------------------");
                        }
                        if (prints == 0 && flashingLight == 1 && printerRecognized == 0)
                        {
                            Console.WriteLine("Conditions:");
                            Console.WriteLine("Printer prints: NO"); 
                            Console.WriteLine("Red Light Flashing: YES"); 
                            Console.WriteLine("Printer Recognized by Computer: NO");
                            Console.WriteLine("Actions to Take:");
                            printerCable();
                            printerSoftware();
                            ink();
                            Console.WriteLine("----------------------------------------------------------------------------------------");
                            Console.WriteLine();
                        }
                    }
                }
            #endregion
            }

            #region: Use switch statements for logic instead of for loop.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int c = 0; c <= 7; c++)
            {
                switch (c)
                {
                    case 0:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("...Printer prints: NO");
                        Console.WriteLine("...Red Light Flashing: NO"); 
                        Console.WriteLine("...Printer Recognized by Computer: NO");
                        Console.WriteLine();
                        Console.WriteLine("Actions to Take:");
                        powerCable();
                        printerCable();
                        printerSoftware();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("...Printer prints: NO"); 
                        Console.WriteLine("...Red Light Flashing: NO"); 
                        Console.WriteLine("...Printer Recognized by Computer: YES");
                        Console.WriteLine("Actions to Take:");
                        paper();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("Printer prints: NO"); 
                        Console.WriteLine("Red Light Flashing: YES"); 
                        Console.WriteLine("Printer Recognized by Computer: NO");
                        Console.WriteLine("Actions to Take:");
                        printerCable();
                        printerSoftware();
                        ink();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("Printer prints: NO"); 
                        Console.WriteLine("Red Light Flashing: YES"); 
                        Console.WriteLine("Printer Recognized by Computer: YES");
                        Console.WriteLine("Actions to Take:");
                        ink();
                        paper();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("Printer prints: YES"); 
                        Console.WriteLine("Red Light Flashing: NO"); 
                        Console.WriteLine("Printer Recognized by Computer: NO");
                        Console.WriteLine("Actions to Take:");
                        printerSoftware();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("Printer prints: YES"); 
                        Console.WriteLine("Red Light Flashing: NO"); 
                        Console.WriteLine("Printer Recognized by Computer: YES");
                        Console.WriteLine("Actions to Take:");
                        Console.WriteLine("*** No action needed!");
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("Printer prints: YES"); 
                        Console.WriteLine("Red Light Flashing: YES"); 
                        Console.WriteLine("Printer Recognized by Computer: NO");
                        Console.WriteLine("Actions to Take:");
                        printerSoftware();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("Conditions:");
                        Console.WriteLine("Printer prints: YES"); 
                        Console.WriteLine("Red Light Flashing: YES"); 
                        Console.WriteLine("Printer Recognized by Computer: YES");
                        Console.WriteLine("Actions to Take:");
                        ink();
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        break;
                }
            }
            #endregion
        }
        /* methods to call in the logic code of main() */
        static void powerCable()
        {
            Console.WriteLine("*** Check the Power Cable ");
        }
        static void printerCable()
        {
            Console.WriteLine("*** Check the Printer Cable ");
        }
        static void printerSoftware()
        {
            Console.WriteLine("*** Check that Printer Software is Installed Correctly ");
        }
        static void ink()
        {
            Console.WriteLine("*** Check/Replace Ink ***");
        }
        static void paper()
        {
            Console.WriteLine("*** Check for Paper Jam ");
        }
    }
}
