using CoffeeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CoffeeeShopDemo.Entities;

namespace CoffeeeShopDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
