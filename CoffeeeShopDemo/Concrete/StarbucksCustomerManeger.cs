using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CoffeeeShopDemo.Abstract;
using CoffeeeShopDemo.Entities;

namespace CoffeeeShopDemo.Concrete
{
    public class StarbucksCustomerManeger:BaseCustomerManager
    {
        private  ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManeger(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person: "+customer.FirstName);
            }

        }

    }
}
