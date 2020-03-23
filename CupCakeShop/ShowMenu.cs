using System;
using System.Collections.Generic;
using CupCakeData;
using CupCakeLib;
using CupCakeLib.Interface;
using CupCakeLib.Models;

namespace CupCakeShop
{
 internal class ShowMenu
    {
        
        internal static void HandleRequest(InputReader req)
        {

            using IRepo DataRepos = Dependencies.CreateDataRepo();
            if (req.Equals(InputReader.PlaceOrder))
            {
                HandleRequestPlaceOrder();
            }
            else if (req.Equals(InputReader.AddCustomer))
            {
                HandleRequestAddCustomer();
            }
            else if (req.Equals(InputReader.SearchCustomer))
            {
                HandleRequestSearchCustomer();
            }
            else if (req.Equals(InputReader.DisplayDetailsOfOrder))
            {
                HandleRequestDisplayDetailsOfOrder();
            }
            else if (req.Equals(InputReader.DisplayOrderHistoryOfLocation))
            {
                HandleRequestDisplayOrderHistoryOfLocation();
            }
            else if (req.Equals(InputReader.DisplayOrderHistoryOfCustomer))
            {
                HandleRequestDisplayOrderHistoryOfCustomer();
            }
            else if (req.Equals(InputReader.DisplayAllLocations))
            {
                HandleRequestDisplayAllLocations();
            }
            else if (req.Equals(InputReader.Exit))
            {
                HandleRequestExit();
            }
            else
            {
                HandleRequestInvalid();
            }
        }


        private static void HandleRequestInvalid()
        {
            Console.WriteLine($"\nPlease check your input\n");
        }

        private static void HandleRequestExit()
        {
           Console.WriteLine("Thank-You\n");
            Environment.Exit(0);
        }

        private static void HandleRequestDisplayAllLocations()
        {
            throw new NotImplementedException();
        }

        private static void HandleRequestDisplayOrderHistoryOfCustomer()
        {
            throw new NotImplementedException();
        }

        private static void HandleRequestDisplayOrderHistoryOfLocation()
        {
            throw new NotImplementedException();
        }

        private static void HandleRequestDisplayDetailsOfOrder()
        {
            throw new NotImplementedException();
        }

        private static void HandleRequestSearchCustomer()
        {
            using IRepo DataRepos = Dependencies.CreateDataRepo();
            Console.WriteLine("Enter the name of the customer: ");

            string Name = Console.ReadLine();

            try
            {
                DataRepos.SearchCustomer(Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("No one by that name.", e);
            }
        
    }

        private static void HandleRequestAddCustomer()
        {
            using IRepo DataRepos = Dependencies.CreateDataRepo();
            Console.WriteLine("Welcome new customer!");

            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine("What is your phone number?");

            var phone = Console.ReadLine();

            //call customer in lib
            var cust = new Customers();
            cust.CName = name;
            cust.Phone = phone;
            //call customer in data(route)
            DataRepos.AddCustomer(cust);
            DataRepos.SaveChanges();

            Console.WriteLine("\nThank you. Your data is saved. \n You are: ");
             cust.DisplayCust();

            Console.WriteLine("\nHow else can I help you today?\n");

          
        }

        private static void HandleRequestPlaceOrder()
        {
        }
    }
}