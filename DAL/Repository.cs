using DAL;
using DAL.Records;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL
{
    public class Repository : IDisposable
    {
        private BankDBEntities db;
        private bool disposedValue;

        public Repository()
        {
            db = new BankDBEntities();
        }

        private int SaveChanges()
        {
            try
            {
                return db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }   
        }

        public Customer GetCustomerByName(string name)
        {
            return db.Customers.FirstOrDefault(c => c.FirstName == name);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers;
            
        }

        public Customer GetCustomerById(int id)
        {
            return db.Customers.Find(id);
        }
        public int CreateOrEditCustomer(Customer customerFromClient)
        {
            var originalCustomer = GetCustomerById(customerFromClient.Id);
            customerFromClient.Classification = db.Classifications.Find(customerFromClient.Classification.Id);
            if (originalCustomer is null)
            {
                AddNewCustomer(customerFromClient);
            }
            else
            {
                UpdateCustomerInfo(originalCustomer, customerFromClient);
            }
            return SaveChanges();
        }
        private void AddNewCustomer(Customer newCustomer)
        {
            db.Customers.Add(newCustomer);

        }
        private TimeSpan DoAndCountTime(Action action)
        {
            DateTime start = DateTime.Now;
            action.Invoke();
            DateTime finish = DateTime.Now;
            TimeSpan time = finish - start;
            return time;
        }

        private void UpdateCustomerInfo(Customer customerFromDB, Customer customerFromClient)
        {
            db.Entry(customerFromDB).CurrentValues.SetValues(customerFromClient);

            ((HashSet<PhoneNumber>)customerFromDB.PhoneNumbers).UnionWith(customerFromClient.PhoneNumbers);
        }

        public IEnumerable<Classification> GetAllClassifications()
        {
            var classifications = db.Classifications;
            return classifications;
        }
             

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
