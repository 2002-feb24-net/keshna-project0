using System;
using System.Collections.Generic;

namespace CupCakeShop
{
 internal class ShowMenu
    {
        
        internal static void HandleRequest(InputReader req)
        {
           
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
            throw new NotImplementedException();
        }

        private static void HandleRequestAddCustomer()
        {
            Console.WriteLine("Welcome new customer!");

            Console.WriteLine("What is your first and last name?");

            var name = Console.ReadLine();

            Console.WriteLine("What is your phone number?");

            var phone = Console.ReadLine();

            //call customer in lib(routes)
            var cust = new Customer();
            cust.Names = name;
            cust.Phone = phone;
            //call customer in data
            DataRepo.AddCustomer(cust);
            DataRepo.Save();

            Console.WriteLine("You are: ");
             cust.DisplayCust();

            Menu.DisplayCMenu();
            InputReader req = Menu.PromptUser();
            ShowMenu.HandleRequest(req);

        }

        private static void HandleRequestPlaceOrder()
        {

            throw new NotImplementedException();
        }
    }
}