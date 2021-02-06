using System;
using CoffeeeShopDemo.Abstract;
using CoffeeeShopDemo.Concrete;
using CoffeeeShopDemo.Entities;
using CoffeeeShopDemo.Adapters;

namespace CoffeeeShopDemo
{
    class Program
    {

        /* Senaryo
         * Kahve dükyanları için müşteri yönetimi yapan bir sistem yapmak istiyoruz.
         * Starbucks ve Neo firması için çalışıyoruz. İki firma da müşterilerini veri
         * tabanına kaydetmek istiyor. Starbucks müşterilerini kaydederken, mutlaka
         * mernis dogrulaması istiyor. Nero müşterileri kaydederken mernis dogrulaması
         * istemiyor. Starbucks müşterileri kahve aldıgında yıldız kazandırmak istiyor.
         * Veriler aynı veri tabanına kaydediliyor gibi düşünelim.(verileri FirmaID'ye 
         * göre  yönetecegiz)
         */
        static void Main(string[] args)
        {
            BaseCustomerManager customerManagerStarbucks = new StarbucksCustomerManeger(new MernisServiceAdapter());
            customerManagerStarbucks.Save(new Customer
            {
                //mernis sistemin calışabimesi için dogru veriler girilmelidir
                DateOfBirth = new DateTime(2000, 7, 12),
                FirstName = "Mustafa",
                LastName = "Öztürk",
                NationalityId = "123"
            }) ;

            BaseCustomerManager customerManagerNero = new NeroCustomerManeger();
            customerManagerNero.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 4),
                FirstName = "Ahmet",
                LastName = "Yıldız",
                NationalityId = "12345678901"
            });
            Console.ReadLine();

        }
    }

}
