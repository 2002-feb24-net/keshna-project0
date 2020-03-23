using CupCakeLib.Interface;
using CupCakeLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CupCakeLib.Interface
{
    public interface IRepo: IDisposable
    {
        void AddCustomer(Customers customer);
        void SaveChanges();

        void SearchCustomer(String name);
    }
}
