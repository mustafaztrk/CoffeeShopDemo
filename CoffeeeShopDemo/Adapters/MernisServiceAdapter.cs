using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using CoffeeeShopDemo.Abstract;
using CoffeeeShopDemo.Entities;
using CoffeeeShopDemo.Adapters;
using MernisServiceReference;

namespace CoffeeeShopDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }

    
    }
}
