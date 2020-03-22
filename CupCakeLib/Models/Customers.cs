using System;
using System.Collections.Generic;

namespace CupCakeLib.Models
{
    public class Customers
    {
        readonly Validation val = new Validation();
        // backing field for the "Name" property.
        // necessary to define this to be able to add validation to the setter.
        private string _name;


        private string _phone { get; set; }

       
        /// <summary>
        /// The customer's ID. Zero indicates a missing value.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The customer's name. Must not be empty.
        /// </summary>
        public string Name
        {
            // expression-body syntax for accessing the backing field.
            // equivalent to "get { return _name; }"
            get => _name;
            set
            {
                val.ValidateCustomerName(value);
                _name = value;
            }
        }

        public string Phone
        {
            // expression-body syntax for accessing the backing field.
            // equivalent to "get { return phone; }"
            get => _phone;
            set
            {
               val.ValidateCustomerPhone(value);
                _phone = value;
            }
        }

    }
}