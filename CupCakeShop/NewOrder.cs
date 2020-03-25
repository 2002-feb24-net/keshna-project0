using System;
using CupCakeData;

namespace CupCakeShop
{
    class NewOrder
    {
        public void PlaceNewOrder()
        {
            Console.Clear();
            Console.WriteLine("Cup Cake Shop\n");

            Console.WriteLine("Enter Customer Name: First and Last");

            string customerName = Console.ReadLine();

            string[] fullName = customerName.Split(' ');

            if (string.IsNullOrEmpty(customerName) || fullName.Length != 2)
            {
                Console.WriteLine("\nInvalid Entry");
                Console.WriteLine("Press a key");
                Console.ReadKey();
                return;
            }

            string firstName = fullName[0];
            string lastName = fullName[1];

            var getCustomerId = new CustomerIdDB();
            int customerId = getCustomerId.GetCustomerIdDB(firstName, lastName);

            if (customerId == 0)
            {
                Console.WriteLine("\nPress a key");
                Console.ReadKey();

                var mainMenu = new MainMenu();
                mainMenu.OpenMainMenu();
            }
            else
            {
                Console.WriteLine($"\n[CustomerId] {customerId}");
                Console.WriteLine("\nPress a key to continue Order");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Cup Cake Shop\n");

            var allProducts = new AllProducts();
            allProducts.GetAllProducts();

            Console.WriteLine("\nEnter ProductId to Purchase: ");
            int cupId = Int32.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Cup Cake Shop\n");

            var allLocations = new AllLocations();
            allLocations.GetAllLocations();

            Console.WriteLine("\nEnter Location (Id) for Order: ");
            int cupLocationId = Int32.Parse(Console.ReadLine());

            //verify location inventory is not zero

            Console.WriteLine("\nEnter Quantity you Wish to Purchase: ");
            int cupQuantity = Int32.Parse(Console.ReadLine());

            //verify inventory available

            decimal orderTotal = (decimal)7.99 * cupQuantity;

            //call to NewOrderDB
            var newOrder = new NewOrderDB();
            newOrder.PlaceNewOrderDB(customerId, cupId, cupLocationId, cupQuantity, orderTotal);

            Console.Clear();
            Console.WriteLine("Cup Cake Shop\n");
            Console.WriteLine("Order Placed. Your total bill for "+ cupQuantity +" is :" + orderTotal  );
            Console.WriteLine("\nPress a key to continue");
            Console.ReadKey();
        }
    }
}
