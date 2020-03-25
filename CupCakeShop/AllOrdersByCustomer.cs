using System;
using System.Collections.Generic;
using System.Text;
using CupCakeData;

namespace CupCakeShop
{
    class AllOrdersByCustomer
    {
        public void GetAllOrdersbyCustomer()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cup Cake Shop\n");
                Console.WriteLine("Enter Customer Name: First and Last");
                Console.WriteLine("(or 1 to Return to Menu)");

                string customerName = Console.ReadLine();

                string[] fullName = customerName.Split(' ');

                if (fullName[0].ToLower() == "1")
                {
                    break;
                }
                else if (string.IsNullOrEmpty(customerName) || fullName.Length != 2)
                {
                    Console.WriteLine("Invalid Name\n");
                    Console.WriteLine("Press a key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    string firstName = fullName[0];
                    string lastName = fullName[1];

                    var getCustomerId = new CustomerIdDB();
                    int customerId = getCustomerId.GetCustomerIdDB(firstName, lastName);

                    if (customerId != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Cup Cake Shop\n");
                        Console.WriteLine($"Order History for {firstName} {lastName}\n");

                        var orderHistory = new OrdersByCustomerDB();
                        orderHistory.GetOrdersByCustomerDB(customerId);

                        Console.WriteLine("\nPress a key to continue");
                        Console.ReadKey();

                        break;
                    }

                    Console.WriteLine("\nPress a key");
                    Console.ReadKey();
                }
            }
        }
    }
}
