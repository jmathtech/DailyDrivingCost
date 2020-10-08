using System;

namespace DailyDrivingCost
{
    class DailyDrivingCost
    {
        static void Main(string[] args)
        {
            /* 
             Name: Jamil Matheny & Bryce Moore
             Date: 10/07/2020
             Class: CIS214
 
             */
            int numOfMiles;
            int costPerGal;
            int milesPerGal;
            int parkFee;
            int tollsPerDay;

            double dailyCost;

            Console.WriteLine("Welcome to the Daily Driving Cost Calculator! \n"); // Title

            Console.Write("Enter the number of miles you drive per day: "); // Prompts the user to enter the number of miles driven per day.
            numOfMiles = Convert.ToInt32(Console.ReadLine()); // User enters the number of miles.

            Console.Write("Enter the cost per gallon of gas <in cents>: "); // Prompts the user to enter cost per gallon
            costPerGal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter average miles per gallon of gas: "); // Prompts the user to enter average miles per gallon
            milesPerGal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the parking fees per day <in cents>: "); // Prompts the user to enter parking fees per day
            parkFee = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the tolls per day <in cents>: "); // Prompts the user to enter tolls per day
            tollsPerDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");


            // Average calculation
            dailyCost = ((numOfMiles / milesPerGal) * costPerGal + parkFee + tollsPerDay) / 100.0;

            Console.WriteLine($"Your daily driving cost is " + dailyCost);

            Console.WriteLine("");

            Console.WriteLine("You can save money by Carpooling!");

         




        }
    }
}
