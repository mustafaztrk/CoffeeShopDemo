using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoffeeeShopDemo.Abstract;
using CoffeeeShopDemo.Entities;
namespace CoffeeeShopDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

 
    }
}
