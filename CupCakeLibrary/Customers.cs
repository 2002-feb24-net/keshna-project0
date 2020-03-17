using System;
using System.Collections.Generic;

namespace CupCakeShop
{
    class Customers
    {


        //private String name { get; set; }
        //private long phone { get; set; }
        private string name = "N/A";
        private long phone = 0;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public long Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }





        public void printC()
        {
            List<Customers> customer = new List<Customers>();

            customer.Add(new Customers { Name= "cody", Phone = 7891234567 });
            customer.Add(new Customers { Name= "mady", Phone = 7891234500 });

            foreach (var rsult in customer)
            {
                Console.WriteLine(rsult);
            }
        }
    public override string ToString()
        {
            return "Name = " + Name + ", Phone No = " + Phone;
        }
    
        public void InputCustomer()
        {

        }


}

 
}