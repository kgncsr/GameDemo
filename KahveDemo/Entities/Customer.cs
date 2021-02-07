using KahveDemo.Abstract;
using System;

namespace KahveDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
