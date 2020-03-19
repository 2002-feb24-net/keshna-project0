using System;
using System.Collections.Generic;
using System.Text;

namespace CupCake
{
    class Menu
    {
        private String CupName = "N/A";
        private Double Price = 0;
        public void printMenu()
        {
          
            List<Menu> menuItem = new List<Menu>();

            menuItem.Add(new Menu { CupName = "Choclate", Price = 10 });
            menuItem.Add(new Menu { CupName = "Strawberry", Price = 8 });
            menuItem.Add(new Menu { CupName = "Vanilla", Price = 7 });

            foreach (var Cup in menuItem)
            {
                Console.WriteLine(Cup);
            }
        }
        public override string ToString()
        {
            return "Cup Cake Flavour = " + CupName + ", Price = " + Price;
        }
    }
}
