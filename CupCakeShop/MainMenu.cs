using System;
using System.Collections.Generic;
using System.Text;

namespace CupCakeShop
{
    class MainMenu
    {
        public void OpenMainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cup Cake Shop\n");

                Console.WriteLine("1. Customer Menu");
                Console.WriteLine("2. Manager Menu");
                Console.WriteLine("3. Exit Application");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        CustomerMenu cMenu = new CustomerMenu();
                        cMenu.OpenCustomerMenu();
                        break;

                    case "2":
                        ManagementMenu mMenu = new ManagementMenu();
                        mMenu.OpenManagementMenu();
                        break;

                    case "3":
                        Console.WriteLine("Exit.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n Invalid Entry");
                        Console.WriteLine("\n Press a key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
