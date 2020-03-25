using System;
using System.Collections.Generic;
using CupCakeData;

namespace CupCakeShop
{
    public class CustomerMenu
    {
        public void OpenCustomerMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cup Cake Shop\n");

                Console.WriteLine("1. New Customer");
                Console.WriteLine("2. Regular Customer");
                Console.WriteLine("3. Return To Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        AddCustomerDB addCustomerDB = new AddCustomerDB();
                        addCustomerDB.AddNewCustomerDB();
                        break;

                    case "2":
                        RegularCustomerMenu();
                        break;

                    case "3":
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.OpenMainMenu();
                        break;

                    default:
                        Console.WriteLine("\n Invalid Input.");
                        Console.WriteLine("\n Press a key to continue");
                        Console.ReadKey();
                        break;
                }

                void RegularCustomerMenu()
                {
                    Console.Clear();
                    Console.WriteLine("Cup Cake Shop\n");

                    Console.WriteLine("1. Place New Order");
                    Console.WriteLine("2. View Order History");
                    Console.WriteLine("3. Return To Main Menu");
                    Console.WriteLine("\nPlease Choose: ");

                    var menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":
                            NewOrder newOrder = new NewOrder();
                            newOrder.PlaceNewOrder();
                            break;

                        case "2":
                            var orderHistory = new AllOrdersByCustomer();
                            orderHistory.GetAllOrdersbyCustomer();
                            break;

                        case "3":
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
}