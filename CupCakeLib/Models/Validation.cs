using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CupCakeLib.Models
{
    class Validation 
    {
        internal void ValidateCustomerName(string name)
        {
            if (name.Length == 0) throw new Exception("Name is empty");
            else if (name.Length < 1) throw new Exception("Name is not long enough!");
            else if (!name.All(Char.IsLetter)) throw new Exception("[!] First name is not alphabetical");
        }

        internal void ValidateCustomerPhone(string phone)
        {
            if (phone.Length < 0 || phone.Length > 10) throw new Exception("Phone length is not valid");
        }
    }
}
