// Program 1
// CIS 199-02
// Due:2/15/2022
// By: R2230

// This program is an application that calculates
// the cost of building a shed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Dry Wall and Window Installation Calculator");
            Console.WriteLine(); // Adds an empty line between the previous and following text displayed in the application.

            double frontLength; // front wall length
            double sideLength;  // side wall length
            double height; // height

                System.Console.Write("Enter the length of the front (in feet): ");
                frontLength = double.Parse(Console.ReadLine()); // assigns frontLength to the number that is entered.

                System.Console.Write("Enter the length of the Side(in feet): ");
                sideLength = double.Parse(Console.ReadLine()); // assigns sideLength to the number that is entered.

                System.Console.Write("Enter the height(in feet): ");
                height = double.Parse(Console.ReadLine()); // assigns height to the number that is entered.

            double window; // window or no window, 0 or 1.
            double windowFee; // $100 fee for a window
            double windowcost; // calculated window fee
            windowFee = 100;

                System.Console.Write("Enter 1 if you want a window, if not enter zero: ");
                window = double.Parse(Console.ReadLine()); // assigns window to the number entered, either 0 or 1.
                windowcost = window * windowFee;

            double dryWall; // cost of dry wall
            double laborCost; // cost of labor per SQ foot

                System.Console.Write("Enter the cost of Dry Wall per square foot: ");
                dryWall = double.Parse(Console.ReadLine()); // assigns dryWall to the number that is entered.

                System.Console.Write("Enter the cost of labor per square feet: ");
                laborCost = double.Parse(Console.ReadLine()); // assigns laborCost to the number that is entered.
                Console.WriteLine(); // Adds an empty line between the previous and following text displayed in the application.


        // Totals:
            double totalFeet; // total square feet of dry wall
            double ceiling; // square footage of ceiling

                ceiling = frontLength * sideLength; 
                totalFeet = (frontLength * height) * 2 + (sideLength * height) * 2 + ceiling;
                Console.WriteLine("Total SQ feet needed: {0}", totalFeet.ToString("0.00")); // outputs totalFeet with two decimal places.


            double extraSQ; // 10% extra square feet
                extraSQ = totalFeet * 1.1;
                System.Console.WriteLine("10% Extra Square feet: {0}", extraSQ.ToString("0.00")); // outputs extraSQ with two decimal places.

            double laborTotal; // total cost of labor
                laborTotal = laborCost * extraSQ;
                System.Console.WriteLine("Labor Cost: {0}", laborTotal.ToString("C")); // outputs laborTotal in currency format.

            double materialCost; // material cost
                materialCost = dryWall * extraSQ;
                System.Console.WriteLine("Material Cost: {0}", materialCost.ToString("C")); // outputs materialCost in currency format.

            double totalCost; // total cost to build the shed
                totalCost = windowcost + laborTotal + materialCost;
                System.Console.WriteLine("Total Cost: {0}", totalCost.ToString("C")); // outputs totalCost in currency format.







        }
    }
}
