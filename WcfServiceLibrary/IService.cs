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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        IEnumerable<CustomerRecord> GetAllCustomers();

        [OperationContract]
        CustomerRecord GetCustomerByName(string name);

        [OperationContract]
        int CreateOrEditCustomer(CustomerRecord customer);

        [OperationContract]
        IEnumerable<ClassificationRecord> GetAllClassifications();
    }
}
