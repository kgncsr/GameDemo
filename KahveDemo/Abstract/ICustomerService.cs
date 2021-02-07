using KahveDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
