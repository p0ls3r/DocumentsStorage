//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocumentsStorageWPFClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentsData", Namespace="http://schemas.datacontract.org/2004/07/DocumentsStorageHost")]
    [System.SerializableAttribute()]
    public partial class DocumentsData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DocumentsStorageWPFClient.ServiceReference1.DocumentData[] documentDatasField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DocumentsStorageWPFClient.ServiceReference1.DocumentData[] documentDatas {
            get {
                return this.documentDatasField;
            }
            set {
                if ((object.ReferenceEquals(this.documentDatasField, value) != true)) {
                    this.documentDatasField = value;
                    this.RaisePropertyChanged("documentDatas");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DocumentData", Namespace="http://schemas.datacontract.org/2004/07/DocumentsStorageHost")]
    [System.SerializableAttribute()]
    public partial class DocumentData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ActualizationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedDateField;
        
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
        public System.DateTime ActualizationDate {
            get {
                return this.ActualizationDateField;
            }
            set {
                if ((this.ActualizationDateField.Equals(value) != true)) {
                    this.ActualizationDateField = value;
                    this.RaisePropertyChanged("ActualizationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDocumentsService")]
    public interface IDocumentsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentsService/GetData", ReplyAction="http://tempuri.org/IDocumentsService/GetDataResponse")]
        DocumentsStorageWPFClient.ServiceReference1.DocumentsData GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDocumentsService/GetData", ReplyAction="http://tempuri.org/IDocumentsService/GetDataResponse")]
        System.Threading.Tasks.Task<DocumentsStorageWPFClient.ServiceReference1.DocumentsData> GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDocumentsServiceChannel : DocumentsStorageWPFClient.ServiceReference1.IDocumentsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentsServiceClient : System.ServiceModel.ClientBase<DocumentsStorageWPFClient.ServiceReference1.IDocumentsService>, DocumentsStorageWPFClient.ServiceReference1.IDocumentsService {
        
        public DocumentsServiceClient() {
        }
        
        public DocumentsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DocumentsStorageWPFClient.ServiceReference1.DocumentsData GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<DocumentsStorageWPFClient.ServiceReference1.DocumentsData> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}
