﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetTokenRC.RCServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserTokenResult", Namespace="http://schemas.datacontract.org/2004/07/IronTracking")]
    [System.SerializableAttribute()]
    public partial class UserTokenResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> exceptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenField;
        
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
        public System.Collections.Generic.Dictionary<string, string> exception {
            get {
                return this.exceptionField;
            }
            set {
                if ((object.ReferenceEquals(this.exceptionField, value) != true)) {
                    this.exceptionField = value;
                    this.RaisePropertyChanged("exception");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenField, value) != true)) {
                    this.tokenField = value;
                    this.RaisePropertyChanged("token");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/IronTracking")]
    [System.SerializableAttribute()]
    public partial class Event : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string altitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string assetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string batteryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string courseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GetTokenRC.RCServiceReference.Customer customerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string directionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ignitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string longitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string odometerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string serialNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shipmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string speedField;
        
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
        public string altitude {
            get {
                return this.altitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.altitudeField, value) != true)) {
                    this.altitudeField = value;
                    this.RaisePropertyChanged("altitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string asset {
            get {
                return this.assetField;
            }
            set {
                if ((object.ReferenceEquals(this.assetField, value) != true)) {
                    this.assetField = value;
                    this.RaisePropertyChanged("asset");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string battery {
            get {
                return this.batteryField;
            }
            set {
                if ((object.ReferenceEquals(this.batteryField, value) != true)) {
                    this.batteryField = value;
                    this.RaisePropertyChanged("battery");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string course {
            get {
                return this.courseField;
            }
            set {
                if ((object.ReferenceEquals(this.courseField, value) != true)) {
                    this.courseField = value;
                    this.RaisePropertyChanged("course");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GetTokenRC.RCServiceReference.Customer customer {
            get {
                return this.customerField;
            }
            set {
                if ((object.ReferenceEquals(this.customerField, value) != true)) {
                    this.customerField = value;
                    this.RaisePropertyChanged("customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string direction {
            get {
                return this.directionField;
            }
            set {
                if ((object.ReferenceEquals(this.directionField, value) != true)) {
                    this.directionField = value;
                    this.RaisePropertyChanged("direction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ignition {
            get {
                return this.ignitionField;
            }
            set {
                if ((object.ReferenceEquals(this.ignitionField, value) != true)) {
                    this.ignitionField = value;
                    this.RaisePropertyChanged("ignition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.latitudeField, value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string longitude {
            get {
                return this.longitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.longitudeField, value) != true)) {
                    this.longitudeField = value;
                    this.RaisePropertyChanged("longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string odometer {
            get {
                return this.odometerField;
            }
            set {
                if ((object.ReferenceEquals(this.odometerField, value) != true)) {
                    this.odometerField = value;
                    this.RaisePropertyChanged("odometer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string serialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.serialNumberField, value) != true)) {
                    this.serialNumberField = value;
                    this.RaisePropertyChanged("serialNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipment {
            get {
                return this.shipmentField;
            }
            set {
                if ((object.ReferenceEquals(this.shipmentField, value) != true)) {
                    this.shipmentField = value;
                    this.RaisePropertyChanged("shipment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string speed {
            get {
                return this.speedField;
            }
            set {
                if ((object.ReferenceEquals(this.speedField, value) != true)) {
                    this.speedField = value;
                    this.RaisePropertyChanged("speed");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/IronTracking")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointResult", Namespace="http://schemas.datacontract.org/2004/07/IronTracking")]
    [System.SerializableAttribute()]
    public partial class AppointResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> exceptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idJobField;
        
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
        public System.Collections.Generic.Dictionary<string, string> exception {
            get {
                return this.exceptionField;
            }
            set {
                if ((object.ReferenceEquals(this.exceptionField, value) != true)) {
                    this.exceptionField = value;
                    this.RaisePropertyChanged("exception");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long idJob {
            get {
                return this.idJobField;
            }
            set {
                if ((this.idJobField.Equals(value) != true)) {
                    this.idJobField = value;
                    this.RaisePropertyChanged("idJob");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RCServiceReference.IRCService")]
    public interface IRCService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRCService/GetUserToken", ReplyAction="http://tempuri.org/IRCService/GetUserTokenResponse")]
        GetTokenRC.RCServiceReference.UserTokenResult GetUserToken(string userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRCService/GetUserToken", ReplyAction="http://tempuri.org/IRCService/GetUserTokenResponse")]
        System.Threading.Tasks.Task<GetTokenRC.RCServiceReference.UserTokenResult> GetUserTokenAsync(string userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRCService/GPSAssetTracking", ReplyAction="http://tempuri.org/IRCService/GPSAssetTrackingResponse")]
        GetTokenRC.RCServiceReference.AppointResult[] GPSAssetTracking(string token, GetTokenRC.RCServiceReference.Event[] events);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRCService/GPSAssetTracking", ReplyAction="http://tempuri.org/IRCService/GPSAssetTrackingResponse")]
        System.Threading.Tasks.Task<GetTokenRC.RCServiceReference.AppointResult[]> GPSAssetTrackingAsync(string token, GetTokenRC.RCServiceReference.Event[] events);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRCServiceChannel : GetTokenRC.RCServiceReference.IRCService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RCServiceClient : System.ServiceModel.ClientBase<GetTokenRC.RCServiceReference.IRCService>, GetTokenRC.RCServiceReference.IRCService {
        
        public RCServiceClient() {
        }
        
        public RCServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RCServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RCServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RCServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GetTokenRC.RCServiceReference.UserTokenResult GetUserToken(string userId, string password) {
            return base.Channel.GetUserToken(userId, password);
        }
        
        public System.Threading.Tasks.Task<GetTokenRC.RCServiceReference.UserTokenResult> GetUserTokenAsync(string userId, string password) {
            return base.Channel.GetUserTokenAsync(userId, password);
        }
        
        public GetTokenRC.RCServiceReference.AppointResult[] GPSAssetTracking(string token, GetTokenRC.RCServiceReference.Event[] events) {
            return base.Channel.GPSAssetTracking(token, events);
        }
        
        public System.Threading.Tasks.Task<GetTokenRC.RCServiceReference.AppointResult[]> GPSAssetTrackingAsync(string token, GetTokenRC.RCServiceReference.Event[] events) {
            return base.Channel.GPSAssetTrackingAsync(token, events);
        }
    }
}