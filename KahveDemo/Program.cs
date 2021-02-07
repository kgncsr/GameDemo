using KahveDemo.Abstract;
using KahveDemo.Concrete;
using KahveDemo.Entities;
using System;

namespace KahveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateofBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demirog", NationalityId = "21513531" });
        }
    }
}
