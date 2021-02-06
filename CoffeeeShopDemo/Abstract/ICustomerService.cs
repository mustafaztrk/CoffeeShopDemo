using System;
using CoffeeeShopDemo.Entities;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace CoffeeeShopDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
