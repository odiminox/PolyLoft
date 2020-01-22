﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dealerinfo.wsvDealerinfo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://programcallbean.accentry.accell.nl", ConfigurationName="wsvDealerinfo.WSVDealerInfoServices")]
    public interface WSVDealerInfoServices {
        
        // CODEGEN: Parameter 'wsvdealerinfo_XMLReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="wsvdealerinfo_XML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="wsvdealerinfo_XMLReturn")]
        Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLResponse wsvdealerinfo_XML(Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLRequest request);
        
        // CODEGEN: Parameter 'wsvdealerinfoReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="wsvdealerinfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="wsvdealerinfoReturn")]
        Dealerinfo.wsvDealerinfo.wsvdealerinfoResponse wsvdealerinfo(Dealerinfo.wsvDealerinfo.wsvdealerinfoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://programcallbean.accentry.accell.nl")]
    public partial class WSVDealerInfoInput : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string returncodeField;
        
        private string wSVBedrijfscodeField;
        
        private string wSVDealercodeField;
        
        private string wSVWachtwoordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public string returncode {
            get {
                return this.returncodeField;
            }
            set {
                this.returncodeField = value;
                this.RaisePropertyChanged("returncode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string WSVBedrijfscode {
            get {
                return this.wSVBedrijfscodeField;
            }
            set {
                this.wSVBedrijfscodeField = value;
                this.RaisePropertyChanged("WSVBedrijfscode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string WSVDealercode {
            get {
                return this.wSVDealercodeField;
            }
            set {
                this.wSVDealercodeField = value;
                this.RaisePropertyChanged("WSVDealercode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public string WSVWachtwoord {
            get {
                return this.wSVWachtwoordField;
            }
            set {
                this.wSVWachtwoordField = value;
                this.RaisePropertyChanged("WSVWachtwoord");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://programcallbean.accentry.accell.nl")]
    public partial class WSVDealerInfoResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string returncodeField;
        
        private string wSVFoutmeldingField;
        
        private string wSVDealerinfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public string returncode {
            get {
                return this.returncodeField;
            }
            set {
                this.returncodeField = value;
                this.RaisePropertyChanged("returncode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string WSVFoutmelding {
            get {
                return this.wSVFoutmeldingField;
            }
            set {
                this.wSVFoutmeldingField = value;
                this.RaisePropertyChanged("WSVFoutmelding");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string WSVDealerinfo {
            get {
                return this.wSVDealerinfoField;
            }
            set {
                this.wSVDealerinfoField = value;
                this.RaisePropertyChanged("WSVDealerinfo");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsvdealerinfo_XML", WrapperNamespace="http://programcallbean.accentry.accell.nl", IsWrapped=true)]
    public partial class wsvdealerinfo_XMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://programcallbean.accentry.accell.nl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Dealerinfo.wsvDealerinfo.WSVDealerInfoInput inputData;
        
        public wsvdealerinfo_XMLRequest() {
        }
        
        public wsvdealerinfo_XMLRequest(Dealerinfo.wsvDealerinfo.WSVDealerInfoInput inputData) {
            this.inputData = inputData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsvdealerinfo_XMLResponse", WrapperNamespace="http://programcallbean.accentry.accell.nl", IsWrapped=true)]
    public partial class wsvdealerinfo_XMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://programcallbean.accentry.accell.nl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string wsvdealerinfo_XMLReturn;
        
        public wsvdealerinfo_XMLResponse() {
        }
        
        public wsvdealerinfo_XMLResponse(string wsvdealerinfo_XMLReturn) {
            this.wsvdealerinfo_XMLReturn = wsvdealerinfo_XMLReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsvdealerinfo", WrapperNamespace="http://programcallbean.accentry.accell.nl", IsWrapped=true)]
    public partial class wsvdealerinfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://programcallbean.accentry.accell.nl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Dealerinfo.wsvDealerinfo.WSVDealerInfoInput inputData;
        
        public wsvdealerinfoRequest() {
        }
        
        public wsvdealerinfoRequest(Dealerinfo.wsvDealerinfo.WSVDealerInfoInput inputData) {
            this.inputData = inputData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="wsvdealerinfoResponse", WrapperNamespace="http://programcallbean.accentry.accell.nl", IsWrapped=true)]
    public partial class wsvdealerinfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://programcallbean.accentry.accell.nl", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public Dealerinfo.wsvDealerinfo.WSVDealerInfoResult wsvdealerinfoReturn;
        
        public wsvdealerinfoResponse() {
        }
        
        public wsvdealerinfoResponse(Dealerinfo.wsvDealerinfo.WSVDealerInfoResult wsvdealerinfoReturn) {
            this.wsvdealerinfoReturn = wsvdealerinfoReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSVDealerInfoServicesChannel : Dealerinfo.wsvDealerinfo.WSVDealerInfoServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSVDealerInfoServicesClient : System.ServiceModel.ClientBase<Dealerinfo.wsvDealerinfo.WSVDealerInfoServices>, Dealerinfo.wsvDealerinfo.WSVDealerInfoServices {
        
        public WSVDealerInfoServicesClient() {
        }
        
        public WSVDealerInfoServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSVDealerInfoServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVDealerInfoServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVDealerInfoServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLResponse Dealerinfo.wsvDealerinfo.WSVDealerInfoServices.wsvdealerinfo_XML(Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLRequest request) {
            return base.Channel.wsvdealerinfo_XML(request);
        }
        
        public string wsvdealerinfo_XML(Dealerinfo.wsvDealerinfo.WSVDealerInfoInput inputData) {
            Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLRequest inValue = new Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLRequest();
            inValue.inputData = inputData;
            Dealerinfo.wsvDealerinfo.wsvdealerinfo_XMLResponse retVal = ((Dealerinfo.wsvDealerinfo.WSVDealerInfoServices)(this)).wsvdealerinfo_XML(inValue);
            return retVal.wsvdealerinfo_XMLReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dealerinfo.wsvDealerinfo.wsvdealerinfoResponse Dealerinfo.wsvDealerinfo.WSVDealerInfoServices.wsvdealerinfo(Dealerinfo.wsvDealerinfo.wsvdealerinfoRequest request) {
            return base.Channel.wsvdealerinfo(request);
        }
        
        public Dealerinfo.wsvDealerinfo.WSVDealerInfoResult wsvdealerinfo(Dealerinfo.wsvDealerinfo.WSVDealerInfoInput inputData) {
            Dealerinfo.wsvDealerinfo.wsvdealerinfoRequest inValue = new Dealerinfo.wsvDealerinfo.wsvdealerinfoRequest();
            inValue.inputData = inputData;
            Dealerinfo.wsvDealerinfo.wsvdealerinfoResponse retVal = ((Dealerinfo.wsvDealerinfo.WSVDealerInfoServices)(this)).wsvdealerinfo(inValue);
            return retVal.wsvdealerinfoReturn;
        }
    }
}
