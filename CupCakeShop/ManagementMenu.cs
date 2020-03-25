using System;
using System.Collections.Generic;
using System.Linq;
using CupCakeData;
using CupCakeData.Entities;
using CupCakeLib;
using CupCakeLib.Models;

namespace CupCakeShop
{
    public class ManagementMenu
    {
        public void OpenManagementMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cup Cake Shop \n");

                Console.WriteLine("1. View All Orders by Customer");
                Console.WriteLine("2. View All Orders by Location");
                Console.WriteLine("3. Search For Customer By Name");
                Console.WriteLine("4. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //View Orders by Customer
                        var allOrders = new AllOrdersByCustomer();
                        allOrders.GetAllOrdersbyCustomer();
                        break;

                    case "2":
                        //View Orders by Location
                        var allOrdersByLocation = new AllOrdersByLocation();
                        allOrdersByLocation.GetOrdersByLocation();
                        break;

                    case "3":
                        //Search for Customer by Name
                        CustomerSearch customerSearch = new CustomerSearch();
                        customerSearch.SearchCustomers();
                        break;


                    case "4":
                        //Return to Main Menu
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.OpenMainMenu();
                        break;

                    default:
                        Console.WriteLine("\n Invalid Input.");
                        Console.WriteLine("\n Press a key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}