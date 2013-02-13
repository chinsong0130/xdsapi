﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MARC.IHE.Xds.Repository;

namespace MARC.IHE.Xds.Registry {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ihe:iti:xds-b:2007", ConfigurationName="Registry.DocumentRegistry_PortType")]
    public interface DocumentRegistry_PortType {
        
        // CODEGEN: Generating message contract since the operation DocumentRegistry_RegistryStoredQuery is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="urn:ihe:iti:2007:RegistryStoredQuery", ReplyAction="urn:ihe:iti:2007:RegistryStoredQueryResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistryResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(RegistryRequestType))]
        MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryResponse DocumentRegistry_RegistryStoredQuery(MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:query:3.0")]
    public partial class AdhocQueryRequest : RegistryRequestType {
        
        private ResponseOptionType responseOptionField;
        
        private AdhocQueryType adhocQueryField;
        
        private bool federatedField;
        
        private string federationField;
        
        private string startIndexField;
        
        private string maxResultsField;
        
        public AdhocQueryRequest() {
            this.federatedField = false;
            this.startIndexField = "0";
            this.maxResultsField = "-1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResponseOptionType ResponseOption {
            get {
                return this.responseOptionField;
            }
            set {
                this.responseOptionField = value;
                this.RaisePropertyChanged("ResponseOption");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", Order=1)]
        public AdhocQueryType AdhocQuery {
            get {
                return this.adhocQueryField;
            }
            set {
                this.adhocQueryField = value;
                this.RaisePropertyChanged("AdhocQuery");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool federated {
            get {
                return this.federatedField;
            }
            set {
                this.federatedField = value;
                this.RaisePropertyChanged("federated");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string federation {
            get {
                return this.federationField;
            }
            set {
                this.federationField = value;
                this.RaisePropertyChanged("federation");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string startIndex {
            get {
                return this.startIndexField;
            }
            set {
                this.startIndexField = value;
                this.RaisePropertyChanged("startIndex");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("-1")]
        public string maxResults {
            get {
                return this.maxResultsField;
            }
            set {
                this.maxResultsField = value;
                this.RaisePropertyChanged("maxResults");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:query:3.0")]
    public partial class ResponseOptionType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ResponseOptionTypeReturnType returnTypeField;
        
        private bool returnComposedObjectsField;
        
        public ResponseOptionType() {
            this.returnTypeField = ResponseOptionTypeReturnType.RegistryObject;
            this.returnComposedObjectsField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ResponseOptionTypeReturnType.RegistryObject)]
        public ResponseOptionTypeReturnType returnType {
            get {
                return this.returnTypeField;
            }
            set {
                this.returnTypeField = value;
                this.RaisePropertyChanged("returnType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool returnComposedObjects {
            get {
                return this.returnComposedObjectsField;
            }
            set {
                this.returnComposedObjectsField = value;
                this.RaisePropertyChanged("returnComposedObjects");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:query:3.0")]
    public enum ResponseOptionTypeReturnType {
        
        /// <remarks/>
        ObjectRef,
        
        /// <remarks/>
        RegistryObject,
        
        /// <remarks/>
        LeafClass,
        
        /// <remarks/>
        LeafClassWithRepositoryItem,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0")]
    public partial class RegistryResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SlotType1[] responseSlotListField;
        
        private RegistryErrorList registryErrorListField;
        
        private string statusField;
        
        private string requestIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Slot", Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", IsNullable=false)]
        public SlotType1[] ResponseSlotList {
            get {
                return this.responseSlotListField;
            }
            set {
                this.responseSlotListField = value;
                this.RaisePropertyChanged("ResponseSlotList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public RegistryErrorList RegistryErrorList {
            get {
                return this.registryErrorListField;
            }
            set {
                this.registryErrorListField = value;
                this.RaisePropertyChanged("RegistryErrorList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string requestId {
            get {
                return this.requestIdField;
            }
            set {
                this.requestIdField = value;
                this.RaisePropertyChanged("requestId");
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
    
   
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0")]
    public partial class RegistryRequestType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private SlotType1[] requestSlotListField;
        
        private string idField;
        
        private string commentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Slot", Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", IsNullable=false)]
        public SlotType1[] RequestSlotList {
            get {
                return this.requestSlotListField;
            }
            set {
                this.requestSlotListField = value;
                this.RaisePropertyChanged("RequestSlotList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
                this.RaisePropertyChanged("comment");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:query:3.0")]
    public partial class AdhocQueryResponse : RegistryResponseType {
        
        private IdentifiableType[] registryObjectListField;
        
        private string startIndexField;
        
        private string totalResultCountField;
        
        public AdhocQueryResponse() {
            this.startIndexField = "0";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Identifiable", IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtrinsicObject", IsNullable = false, Type = typeof(ExtrinsicObjectType))]
        public IdentifiableType[] RegistryObjectList {
            get {
                return this.registryObjectListField;
            }
            set {
                this.registryObjectListField = value;
                this.RaisePropertyChanged("RegistryObjectList");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string startIndex {
            get {
                return this.startIndexField;
            }
            set {
                this.startIndexField = value;
                this.RaisePropertyChanged("startIndex");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string totalResultCount {
            get {
                return this.totalResultCountField;
            }
            set {
                this.totalResultCountField = value;
                this.RaisePropertyChanged("totalResultCount");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DocumentRegistry_RegistryStoredQueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:query:3.0", Order=0)]
        public MARC.IHE.Xds.Registry.AdhocQueryRequest AdhocQueryRequest;
        
        public DocumentRegistry_RegistryStoredQueryRequest() {
        }
        
        public DocumentRegistry_RegistryStoredQueryRequest(MARC.IHE.Xds.Registry.AdhocQueryRequest AdhocQueryRequest) {
            this.AdhocQueryRequest = AdhocQueryRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DocumentRegistry_RegistryStoredQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:oasis:names:tc:ebxml-regrep:xsd:query:3.0", Order=0)]
        public MARC.IHE.Xds.Registry.AdhocQueryResponse AdhocQueryResponse;
        
        public DocumentRegistry_RegistryStoredQueryResponse() {
        }
        
        public DocumentRegistry_RegistryStoredQueryResponse(MARC.IHE.Xds.Registry.AdhocQueryResponse AdhocQueryResponse) {
            this.AdhocQueryResponse = AdhocQueryResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DocumentRegistry_PortTypeChannel : MARC.IHE.Xds.Registry.DocumentRegistry_PortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentRegistry_PortTypeClient : System.ServiceModel.ClientBase<MARC.IHE.Xds.Registry.DocumentRegistry_PortType>, MARC.IHE.Xds.Registry.DocumentRegistry_PortType {
        
        public DocumentRegistry_PortTypeClient() {
        }
        
        public DocumentRegistry_PortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DocumentRegistry_PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentRegistry_PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DocumentRegistry_PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryResponse MARC.IHE.Xds.Registry.DocumentRegistry_PortType.DocumentRegistry_RegistryStoredQuery(MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryRequest request) {
            return base.Channel.DocumentRegistry_RegistryStoredQuery(request);
        }
        
        public MARC.IHE.Xds.Registry.AdhocQueryResponse DocumentRegistry_RegistryStoredQuery(MARC.IHE.Xds.Registry.AdhocQueryRequest AdhocQueryRequest) {
            MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryRequest inValue = new MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryRequest();
            inValue.AdhocQueryRequest = AdhocQueryRequest;
            MARC.IHE.Xds.Registry.DocumentRegistry_RegistryStoredQueryResponse retVal = ((MARC.IHE.Xds.Registry.DocumentRegistry_PortType)(this)).DocumentRegistry_RegistryStoredQuery(inValue);
            return retVal.AdhocQueryResponse;
        }
    }
}
