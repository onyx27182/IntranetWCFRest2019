﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdeaPOCO", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class IdeaPOCO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdeaTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NameIdField;
        
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
        public string IdeaText {
            get {
                return this.IdeaTextField;
            }
            set {
                if ((object.ReferenceEquals(this.IdeaTextField, value) != true)) {
                    this.IdeaTextField = value;
                    this.RaisePropertyChanged("IdeaText");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NameId {
            get {
                return this.NameIdField;
            }
            set {
                if ((this.NameIdField.Equals(value) != true)) {
                    this.NameIdField = value;
                    this.RaisePropertyChanged("NameId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PeoplePOCO", Namespace="http://schemas.datacontract.org/2004/07/WCFREST")]
    [System.SerializableAttribute()]
    public partial class PeoplePOCO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ISytech")]
    public interface ISytech {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISytech/GetIdeas", ReplyAction="http://tempuri.org/ISytech/GetIdeasResponse")]
        ConsoleApp1.ServiceReference2.IdeaPOCO[] GetIdeas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISytech/GetIdeas", ReplyAction="http://tempuri.org/ISytech/GetIdeasResponse")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference2.IdeaPOCO[]> GetIdeasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISytech/SaveIdea", ReplyAction="http://tempuri.org/ISytech/SaveIdeaResponse")]
        void SaveIdea(string ideaText, string personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISytech/SaveIdea", ReplyAction="http://tempuri.org/ISytech/SaveIdeaResponse")]
        System.Threading.Tasks.Task SaveIdeaAsync(string ideaText, string personId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISytech/GetPeople", ReplyAction="http://tempuri.org/ISytech/GetPeopleResponse")]
        ConsoleApp1.ServiceReference2.PeoplePOCO[] GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISytech/GetPeople", ReplyAction="http://tempuri.org/ISytech/GetPeopleResponse")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference2.PeoplePOCO[]> GetPeopleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISytechChannel : ConsoleApp1.ServiceReference2.ISytech, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SytechClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference2.ISytech>, ConsoleApp1.ServiceReference2.ISytech {
        
        public SytechClient() {
        }
        
        public SytechClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SytechClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SytechClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SytechClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApp1.ServiceReference2.IdeaPOCO[] GetIdeas() {
            return base.Channel.GetIdeas();
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference2.IdeaPOCO[]> GetIdeasAsync() {
            return base.Channel.GetIdeasAsync();
        }
        
        public void SaveIdea(string ideaText, string personId) {
            base.Channel.SaveIdea(ideaText, personId);
        }
        
        public System.Threading.Tasks.Task SaveIdeaAsync(string ideaText, string personId) {
            return base.Channel.SaveIdeaAsync(ideaText, personId);
        }
        
        public ConsoleApp1.ServiceReference2.PeoplePOCO[] GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference2.PeoplePOCO[]> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
    }
}
