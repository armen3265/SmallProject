using DAL;
using DAL.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
   public class Service : IService
    {
        public int CreateOrEditCustomer(CustomerRecord customerRecord)
        {
            var repo = new Repository();
            Customer customer = Mappers.modelsDTO.Map<Customer>(customerRecord);
            int result = repo.CreateOrEditCustomer(customer);
            repo.Dispose();
            return result;
        }

        public IEnumerable<ClassificationRecord> GetAllClassifications()
        {
            var repo = new Repository();
            var clasifications = repo.GetAllClassifications();
            var mappedClassifications = Mappers.modelsDTO.Map<IEnumerable<Classification>,IEnumerable<ClassificationRecord>>(clasifications);
                repo.Dispose();
            return mappedClassifications;

        }

        public IEnumerable<CustomerRecord> GetAllCustomers()
        {
            var repo = new Repository();
            var customers = repo.GetCustomers();
            var mappedCustomers = Mappers.modelsDTO.Map<IEnumerable<Customer>, IEnumerable<CustomerRecord>>(customers);
            repo.Dispose();
            return mappedCustomers;
        }

        public CustomerRecord GetCustomerByName(string name)
        {
            var repo = new Repository();
            var customer = repo.GetCustomerByName(name);
            var mappedCustomer= Mappers.modelsDTO.Map<Customer, CustomerRecord>(customer);
            repo.Dispose();
            return mappedCustomer;
        }
    }
    
}
