﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.SmallProjectProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/DAL.Records")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApplication.SmallProjectProxy.Classification ClassificationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ClientApplication.SmallProjectProxy.PhoneNumber> PhoneNumbersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApplication.SmallProjectProxy.Classification Classification {
            get {
                return this.ClassificationField;
            }
            set {
                if ((object.ReferenceEquals(this.ClassificationField, value) != true)) {
                    this.ClassificationField = value;
                    this.RaisePropertyChanged("Classification");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ClientApplication.SmallProjectProxy.PhoneNumber> PhoneNumbers {
            get {
                return this.PhoneNumbersField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumbersField, value) != true)) {
                    this.PhoneNumbersField = value;
                    this.RaisePropertyChanged("PhoneNumbers");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Classification", Namespace="http://schemas.datacontract.org/2004/07/DAL.Records")]
    [System.SerializableAttribute()]
    public partial class Classification : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhoneNumber", Namespace="http://schemas.datacontract.org/2004/07/DAL.Records")]
    [System.SerializableAttribute()]
    public partial class PhoneNumber : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SmallProjectProxy.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllCustomers", ReplyAction="http://tempuri.org/IService/GetAllCustomersResponse")]
        System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Customer> GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllCustomers", ReplyAction="http://tempuri.org/IService/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Customer>> GetAllCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCustomerByName", ReplyAction="http://tempuri.org/IService/GetCustomerByNameResponse")]
        ClientApplication.SmallProjectProxy.Customer GetCustomerByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCustomerByName", ReplyAction="http://tempuri.org/IService/GetCustomerByNameResponse")]
        System.Threading.Tasks.Task<ClientApplication.SmallProjectProxy.Customer> GetCustomerByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateOrEditCustomer", ReplyAction="http://tempuri.org/IService/CreateOrEditCustomerResponse")]
        int CreateOrEditCustomer(ClientApplication.SmallProjectProxy.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateOrEditCustomer", ReplyAction="http://tempuri.org/IService/CreateOrEditCustomerResponse")]
        System.Threading.Tasks.Task<int> CreateOrEditCustomerAsync(ClientApplication.SmallProjectProxy.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllClassifications", ReplyAction="http://tempuri.org/IService/GetAllClassificationsResponse")]
        System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Classification> GetAllClassifications();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllClassifications", ReplyAction="http://tempuri.org/IService/GetAllClassificationsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Classification>> GetAllClassificationsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClientApplication.SmallProjectProxy.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientApplication.SmallProjectProxy.IService>, ClientApplication.SmallProjectProxy.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Customer> GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Customer>> GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
        
        public ClientApplication.SmallProjectProxy.Customer GetCustomerByName(string name) {
            return base.Channel.GetCustomerByName(name);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.SmallProjectProxy.Customer> GetCustomerByNameAsync(string name) {
            return base.Channel.GetCustomerByNameAsync(name);
        }
        
        public int CreateOrEditCustomer(ClientApplication.SmallProjectProxy.Customer customer) {
            return base.Channel.CreateOrEditCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<int> CreateOrEditCustomerAsync(ClientApplication.SmallProjectProxy.Customer customer) {
            return base.Channel.CreateOrEditCustomerAsync(customer);
        }
        
        public System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Classification> GetAllClassifications() {
            return base.Channel.GetAllClassifications();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ClientApplication.SmallProjectProxy.Classification>> GetAllClassificationsAsync() {
            return base.Channel.GetAllClassificationsAsync();
        }
    }
}