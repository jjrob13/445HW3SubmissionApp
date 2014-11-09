﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HW3SubmissionPage.ServiceReferenceNearByPlaces {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlacesList", Namespace="http://schemas.datacontract.org/2004/07/NearByPlaces")]
    [System.SerializableAttribute()]
    public partial class PlacesList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string formatted_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string latField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lngField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string price_levelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ratingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string referenceIdField;
        
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
        public string formatted_address {
            get {
                return this.formatted_addressField;
            }
            set {
                if ((object.ReferenceEquals(this.formatted_addressField, value) != true)) {
                    this.formatted_addressField = value;
                    this.RaisePropertyChanged("formatted_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lat {
            get {
                return this.latField;
            }
            set {
                if ((object.ReferenceEquals(this.latField, value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lng {
            get {
                return this.lngField;
            }
            set {
                if ((object.ReferenceEquals(this.lngField, value) != true)) {
                    this.lngField = value;
                    this.RaisePropertyChanged("lng");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string price_level {
            get {
                return this.price_levelField;
            }
            set {
                if ((object.ReferenceEquals(this.price_levelField, value) != true)) {
                    this.price_levelField = value;
                    this.RaisePropertyChanged("price_level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rating {
            get {
                return this.ratingField;
            }
            set {
                if ((object.ReferenceEquals(this.ratingField, value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string referenceId {
            get {
                return this.referenceIdField;
            }
            set {
                if ((object.ReferenceEquals(this.referenceIdField, value) != true)) {
                    this.referenceIdField = value;
                    this.RaisePropertyChanged("referenceId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceNearByPlaces.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlacesData", ReplyAction="http://tempuri.org/IService1/GetPlacesDataResponse")]
        HW3SubmissionPage.ServiceReferenceNearByPlaces.PlacesList[] GetPlacesData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlacesData", ReplyAction="http://tempuri.org/IService1/GetPlacesDataResponse")]
        System.Threading.Tasks.Task<HW3SubmissionPage.ServiceReferenceNearByPlaces.PlacesList[]> GetPlacesDataAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : HW3SubmissionPage.ServiceReferenceNearByPlaces.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<HW3SubmissionPage.ServiceReferenceNearByPlaces.IService1>, HW3SubmissionPage.ServiceReferenceNearByPlaces.IService1 {
        
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
        
        public HW3SubmissionPage.ServiceReferenceNearByPlaces.PlacesList[] GetPlacesData(string value) {
            return base.Channel.GetPlacesData(value);
        }
        
        public System.Threading.Tasks.Task<HW3SubmissionPage.ServiceReferenceNearByPlaces.PlacesList[]> GetPlacesDataAsync(string value) {
            return base.Channel.GetPlacesDataAsync(value);
        }
    }
}