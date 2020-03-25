using System;
using System.Collections.Generic;
using System.Text;
using CupCakeData;

namespace CupCakeShop
{
    class CustomerSearch
    {
        public void SearchCustomers()
        {
            Console.Clear();
            Console.WriteLine("Cup Cake Shop\n");

            Console.WriteLine("Enter Customer Name: First and Last");

            string customerName = Console.ReadLine();

            string[] fullName = customerName.Split(' ');

            string firstName = fullName[0];
            string lastName = fullName[1];

            var searchCustomer = new SearchCustomerDB();
            searchCustomer.SearchForCustomerDB(firstName, lastName);

            Console.WriteLine("\nPress a key to continue: ");
            Console.ReadKey();
        }
    }
}
