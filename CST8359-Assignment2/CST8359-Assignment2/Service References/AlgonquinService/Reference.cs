﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CST8359_Assignment2.AlgonquinService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AlgonquinCollegeUser", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUserExtended))]
    public partial class AlgonquinCollegeUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        private bool IsStudentField;
        
        private bool IsStaffField;
        
        private bool IsFacultyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsStudent {
            get {
                return this.IsStudentField;
            }
            set {
                if ((this.IsStudentField.Equals(value) != true)) {
                    this.IsStudentField = value;
                    this.RaisePropertyChanged("IsStudent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public bool IsStaff {
            get {
                return this.IsStaffField;
            }
            set {
                if ((this.IsStaffField.Equals(value) != true)) {
                    this.IsStaffField = value;
                    this.RaisePropertyChanged("IsStaff");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public bool IsFaculty {
            get {
                return this.IsFacultyField;
            }
            set {
                if ((this.IsFacultyField.Equals(value) != true)) {
                    this.IsFacultyField = value;
                    this.RaisePropertyChanged("IsFaculty");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AlgonquinCollegeUserExtended", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AlgonquinCollegeUserExtended : CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StudentNumber {
            get {
                return this.StudentNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNumberField, value) != true)) {
                    this.StudentNumberField = value;
                    this.RaisePropertyChanged("StudentNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EmployeeNumber {
            get {
                return this.EmployeeNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNumberField, value) != true)) {
                    this.EmployeeNumberField = value;
                    this.RaisePropertyChanged("EmployeeNumber");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AlgonquinService.AuthenticateServiceSoap")]
    public interface AuthenticateServiceSoap {
        
        // CODEGEN: Generating message contract since element name strUserName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUser", ReplyAction="*")]
        CST8359_Assignment2.AlgonquinService.AuthenticateUserResponse AuthenticateUser(CST8359_Assignment2.AlgonquinService.AuthenticateUserRequest request);
        
        // CODEGEN: Generating message contract since element name strUserName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUserExtended", ReplyAction="*")]
        CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedResponse AuthenticateUserExtended(CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequest request);
        
        // CODEGEN: Generating message contract since element name strUserName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserInfo", ReplyAction="*")]
        CST8359_Assignment2.AlgonquinService.GetUserInfoResponse GetUserInfo(CST8359_Assignment2.AlgonquinService.GetUserInfoRequest request);
        
        // CODEGEN: Generating message contract since element name strLastName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchUsersByLastName", ReplyAction="*")]
        CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameResponse SearchUsersByLastName(CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUser", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.AuthenticateUserRequestBody Body;
        
        public AuthenticateUserRequest() {
        }
        
        public AuthenticateUserRequest(CST8359_Assignment2.AlgonquinService.AuthenticateUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strPassword;
        
        public AuthenticateUserRequestBody() {
        }
        
        public AuthenticateUserRequestBody(string strUserName, string strPassword) {
            this.strUserName = strUserName;
            this.strPassword = strPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.AuthenticateUserResponseBody Body;
        
        public AuthenticateUserResponse() {
        }
        
        public AuthenticateUserResponse(CST8359_Assignment2.AlgonquinService.AuthenticateUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser AuthenticateUserResult;
        
        public AuthenticateUserResponseBody() {
        }
        
        public AuthenticateUserResponseBody(CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser AuthenticateUserResult) {
            this.AuthenticateUserResult = AuthenticateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserExtendedRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserExtended", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequestBody Body;
        
        public AuthenticateUserExtendedRequest() {
        }
        
        public AuthenticateUserExtendedRequest(CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserExtendedRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strPassword;
        
        public AuthenticateUserExtendedRequestBody() {
        }
        
        public AuthenticateUserExtendedRequestBody(string strUserName, string strPassword) {
            this.strUserName = strUserName;
            this.strPassword = strPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AuthenticateUserExtendedResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AuthenticateUserExtendedResponse", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedResponseBody Body;
        
        public AuthenticateUserExtendedResponse() {
        }
        
        public AuthenticateUserExtendedResponse(CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthenticateUserExtendedResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUserExtended AuthenticateUserExtendedResult;
        
        public AuthenticateUserExtendedResponseBody() {
        }
        
        public AuthenticateUserExtendedResponseBody(CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUserExtended AuthenticateUserExtendedResult) {
            this.AuthenticateUserExtendedResult = AuthenticateUserExtendedResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserInfo", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.GetUserInfoRequestBody Body;
        
        public GetUserInfoRequest() {
        }
        
        public GetUserInfoRequest(CST8359_Assignment2.AlgonquinService.GetUserInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetUserInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strAdminUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strAdminPassword;
        
        public GetUserInfoRequestBody() {
        }
        
        public GetUserInfoRequestBody(string strUserName, string strAdminUserName, string strAdminPassword) {
            this.strUserName = strUserName;
            this.strAdminUserName = strAdminUserName;
            this.strAdminPassword = strAdminPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.GetUserInfoResponseBody Body;
        
        public GetUserInfoResponse() {
        }
        
        public GetUserInfoResponse(CST8359_Assignment2.AlgonquinService.GetUserInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetUserInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser GetUserInfoResult;
        
        public GetUserInfoResponseBody() {
        }
        
        public GetUserInfoResponseBody(CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser GetUserInfoResult) {
            this.GetUserInfoResult = GetUserInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchUsersByLastNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchUsersByLastName", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequestBody Body;
        
        public SearchUsersByLastNameRequest() {
        }
        
        public SearchUsersByLastNameRequest(CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchUsersByLastNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strLastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strAdminUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strAdminPassword;
        
        public SearchUsersByLastNameRequestBody() {
        }
        
        public SearchUsersByLastNameRequestBody(string strLastName, string strAdminUserName, string strAdminPassword) {
            this.strLastName = strLastName;
            this.strAdminUserName = strAdminUserName;
            this.strAdminPassword = strAdminPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchUsersByLastNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchUsersByLastNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameResponseBody Body;
        
        public SearchUsersByLastNameResponse() {
        }
        
        public SearchUsersByLastNameResponse(CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchUsersByLastNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser[] SearchUsersByLastNameResult;
        
        public SearchUsersByLastNameResponseBody() {
        }
        
        public SearchUsersByLastNameResponseBody(CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser[] SearchUsersByLastNameResult) {
            this.SearchUsersByLastNameResult = SearchUsersByLastNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticateServiceSoapChannel : CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticateServiceSoapClient : System.ServiceModel.ClientBase<CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap>, CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap {
        
        public AuthenticateServiceSoapClient() {
        }
        
        public AuthenticateServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticateServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticateServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CST8359_Assignment2.AlgonquinService.AuthenticateUserResponse CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap.AuthenticateUser(CST8359_Assignment2.AlgonquinService.AuthenticateUserRequest request) {
            return base.Channel.AuthenticateUser(request);
        }
        
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser AuthenticateUser(string strUserName, string strPassword) {
            CST8359_Assignment2.AlgonquinService.AuthenticateUserRequest inValue = new CST8359_Assignment2.AlgonquinService.AuthenticateUserRequest();
            inValue.Body = new CST8359_Assignment2.AlgonquinService.AuthenticateUserRequestBody();
            inValue.Body.strUserName = strUserName;
            inValue.Body.strPassword = strPassword;
            CST8359_Assignment2.AlgonquinService.AuthenticateUserResponse retVal = ((CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap)(this)).AuthenticateUser(inValue);
            return retVal.Body.AuthenticateUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedResponse CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap.AuthenticateUserExtended(CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequest request) {
            return base.Channel.AuthenticateUserExtended(request);
        }
        
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUserExtended AuthenticateUserExtended(string strUserName, string strPassword) {
            CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequest inValue = new CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequest();
            inValue.Body = new CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedRequestBody();
            inValue.Body.strUserName = strUserName;
            inValue.Body.strPassword = strPassword;
            CST8359_Assignment2.AlgonquinService.AuthenticateUserExtendedResponse retVal = ((CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap)(this)).AuthenticateUserExtended(inValue);
            return retVal.Body.AuthenticateUserExtendedResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CST8359_Assignment2.AlgonquinService.GetUserInfoResponse CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap.GetUserInfo(CST8359_Assignment2.AlgonquinService.GetUserInfoRequest request) {
            return base.Channel.GetUserInfo(request);
        }
        
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser GetUserInfo(string strUserName, string strAdminUserName, string strAdminPassword) {
            CST8359_Assignment2.AlgonquinService.GetUserInfoRequest inValue = new CST8359_Assignment2.AlgonquinService.GetUserInfoRequest();
            inValue.Body = new CST8359_Assignment2.AlgonquinService.GetUserInfoRequestBody();
            inValue.Body.strUserName = strUserName;
            inValue.Body.strAdminUserName = strAdminUserName;
            inValue.Body.strAdminPassword = strAdminPassword;
            CST8359_Assignment2.AlgonquinService.GetUserInfoResponse retVal = ((CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap)(this)).GetUserInfo(inValue);
            return retVal.Body.GetUserInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameResponse CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap.SearchUsersByLastName(CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequest request) {
            return base.Channel.SearchUsersByLastName(request);
        }
        
        public CST8359_Assignment2.AlgonquinService.AlgonquinCollegeUser[] SearchUsersByLastName(string strLastName, string strAdminUserName, string strAdminPassword) {
            CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequest inValue = new CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequest();
            inValue.Body = new CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameRequestBody();
            inValue.Body.strLastName = strLastName;
            inValue.Body.strAdminUserName = strAdminUserName;
            inValue.Body.strAdminPassword = strAdminPassword;
            CST8359_Assignment2.AlgonquinService.SearchUsersByLastNameResponse retVal = ((CST8359_Assignment2.AlgonquinService.AuthenticateServiceSoap)(this)).SearchUsersByLastName(inValue);
            return retVal.Body.SearchUsersByLastNameResult;
        }
    }
}