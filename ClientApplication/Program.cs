using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApplication.SmallProjectProxy;

namespace ClientApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(ServiceClient proxy = new ServiceClient())
            {


                var classifications = proxy.GetAllClassifications();
                Customer customer = proxy.GetCustomerByName("Hakob");
                customer.Classification = classifications[1];
                customer.PhoneNumbers.AddRange(new List<PhoneNumber>()
                {
                 new PhoneNumber()
                 {
                    Number = "011222221"
                 },
                 new PhoneNumber()
                 {
                     Number = "032222231"
                 },
                 new PhoneNumber()
                 {
                     Number = "091222223"
                 }
                 }
                );
                proxy.CreateOrEditCustomer(customer);
                PrintCustomers(proxy);

                Console.ReadLine();

            }

            
        }
        public static void PrintCustomers(ServiceClient proxy)
        {
            var customers = proxy.GetAllCustomers();
            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Id}: {c.FirstName}: {c.Classification.Name}");
                foreach (var p in c.PhoneNumbers)
                {
                    Console.WriteLine(p.Number);
                }
            }
        }
    }
}
