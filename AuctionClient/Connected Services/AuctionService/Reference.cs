﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuctionClient.AuctionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuctionItem", Namespace="http://schemas.datacontract.org/2004/07/WcfTrialExam")]
    [System.SerializableAttribute()]
    public partial class AuctionItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BidCustomerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BidCustomerPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BidPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BidTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RatingPriceField;
        
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
        public string BidCustomerName {
            get {
                return this.BidCustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BidCustomerNameField, value) != true)) {
                    this.BidCustomerNameField = value;
                    this.RaisePropertyChanged("BidCustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BidCustomerPhone {
            get {
                return this.BidCustomerPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.BidCustomerPhoneField, value) != true)) {
                    this.BidCustomerPhoneField = value;
                    this.RaisePropertyChanged("BidCustomerPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BidPrice {
            get {
                return this.BidPriceField;
            }
            set {
                if ((this.BidPriceField.Equals(value) != true)) {
                    this.BidPriceField = value;
                    this.RaisePropertyChanged("BidPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BidTime {
            get {
                return this.BidTimeField;
            }
            set {
                if ((this.BidTimeField.Equals(value) != true)) {
                    this.BidTimeField = value;
                    this.RaisePropertyChanged("BidTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemDescription {
            get {
                return this.ItemDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemDescriptionField, value) != true)) {
                    this.ItemDescriptionField = value;
                    this.RaisePropertyChanged("ItemDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemNumber {
            get {
                return this.ItemNumberField;
            }
            set {
                if ((this.ItemNumberField.Equals(value) != true)) {
                    this.ItemNumberField = value;
                    this.RaisePropertyChanged("ItemNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RatingPrice {
            get {
                return this.RatingPriceField;
            }
            set {
                if ((this.RatingPriceField.Equals(value) != true)) {
                    this.RatingPriceField = value;
                    this.RaisePropertyChanged("RatingPrice");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuctionService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAuctionItems", ReplyAction="http://tempuri.org/IService1/GetAllAuctionItemsResponse")]
        AuctionClient.AuctionService.AuctionItem[] GetAllAuctionItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAuctionItems", ReplyAction="http://tempuri.org/IService1/GetAllAuctionItemsResponse")]
        System.Threading.Tasks.Task<AuctionClient.AuctionService.AuctionItem[]> GetAllAuctionItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuctionItemById", ReplyAction="http://tempuri.org/IService1/GetAuctionItemByIdResponse")]
        AuctionClient.AuctionService.AuctionItem GetAuctionItemById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAuctionItemById", ReplyAction="http://tempuri.org/IService1/GetAuctionItemByIdResponse")]
        System.Threading.Tasks.Task<AuctionClient.AuctionService.AuctionItem> GetAuctionItemByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AuctionClient.AuctionService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AuctionClient.AuctionService.IService1>, AuctionClient.AuctionService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AuctionClient.AuctionService.AuctionItem[] GetAllAuctionItems() {
            return base.Channel.GetAllAuctionItems();
        }
        
        public System.Threading.Tasks.Task<AuctionClient.AuctionService.AuctionItem[]> GetAllAuctionItemsAsync() {
            return base.Channel.GetAllAuctionItemsAsync();
        }
        
        public AuctionClient.AuctionService.AuctionItem GetAuctionItemById(int id) {
            return base.Channel.GetAuctionItemById(id);
        }
        
        public System.Threading.Tasks.Task<AuctionClient.AuctionService.AuctionItem> GetAuctionItemByIdAsync(int id) {
            return base.Channel.GetAuctionItemByIdAsync(id);
        }
    }
}
