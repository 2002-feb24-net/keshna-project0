using System;
using Microsoft.EntityFrameworkCore;
//using NLog;
using CupCakeData.Entities;
using CupCakeData;

namespace CupCakeShop
{
    public class AllOrdersByLocation
    {

        public void GetOrdersByLocation()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cup Cake Shop\n");
                Console.WriteLine("All Locations:");

                var allLocations = new AllLocations();
                allLocations.GetAllLocations();

                Console.WriteLine("\nEnter LocationID for All Orders at Location");
                string inputLocationID = Console.ReadLine();

                if (!(string.IsNullOrEmpty(inputLocationID)))
                {
                    int locationID = int.Parse(inputLocationID);
                    Console.Clear();
                    Console.WriteLine("Cup Cake Shop\n");

                    var allOrdersAtLocation = new OrdersByLocationDB();
                    allOrdersAtLocation.GetOrdersByLocationDB(locationID);

                    break;
                }

                Console.WriteLine("\n Invalid Input.");
                Console.WriteLine("\n Press a key to continue");
                Console.ReadKey();
            }
        }
    }
    }