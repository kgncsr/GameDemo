using KahveDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to Db : "+customer.FirstName);
        }
    }
}
