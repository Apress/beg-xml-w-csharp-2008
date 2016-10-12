﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
// 
#pragma warning disable 1591

namespace WindowsApplication64.localhost {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GetEmployeesEndPointSoap", Namespace="my_unique_namespace")]
    public partial class GetEmployeesEndPoint : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetEmployeesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GetEmployeesEndPoint() {
            this.Url = global::WindowsApplication64.Properties.Settings.Default.WindowsApplication64_localhost_GetEmployeesEndPoint;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetEmployeesCompletedEventHandler GetEmployeesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("my_unique_namespaceGetEmployees", RequestNamespace="my_unique_namespace", ResponseNamespace="my_unique_namespace", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(typeof(SqlMessage), Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlResultStream", IsNullable=false)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("SqlResultCode", typeof(int), Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlResultStream", IsNullable=false)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(typeof(SqlRowCount), Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlResultStream", IsNullable=false)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("SqlRowSet", typeof(System.Data.DataSet), Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlResultStream", IsNullable=false)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(typeof(SqlTransaction), Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlResultStream", IsNullable=false)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("SqlXml", typeof(System.Xml.XmlNode), Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlResultStream", IsNullable=false)]
        public object[] GetEmployees() {
            object[] results = this.Invoke("GetEmployees", new object[0]);
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEmployeesAsync() {
            this.GetEmployeesAsync(null);
        }
        
        /// <remarks/>
        public void GetEmployeesAsync(object userState) {
            if ((this.GetEmployeesOperationCompleted == null)) {
                this.GetEmployeesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEmployeesOperationCompleted);
            }
            this.InvokeAsync("GetEmployees", new object[0], this.GetEmployeesOperationCompleted, userState);
        }
        
        private void OnGetEmployeesOperationCompleted(object arg) {
            if ((this.GetEmployeesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEmployeesCompleted(this, new GetEmployeesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlMessage")]
    public partial class SqlMessage {
        
        private int classField;
        
        private int lineNumberField;
        
        private string messageField;
        
        private int numberField;
        
        private string procedureField;
        
        private string serverField;
        
        private string sourceField;
        
        private int stateField;
        
        /// <remarks/>
        public int Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        public int LineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public int Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        public string Procedure {
            get {
                return this.procedureField;
            }
            set {
                this.procedureField = value;
            }
        }
        
        /// <remarks/>
        public string Server {
            get {
                return this.serverField;
            }
            set {
                this.serverField = value;
            }
        }
        
        /// <remarks/>
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        public int State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlTransaction")]
    public partial class SqlTransaction {
        
        private byte[] descriptorField;
        
        private SqlTransactionType typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Descriptor {
            get {
                return this.descriptorField;
            }
            set {
                this.descriptorField = value;
            }
        }
        
        /// <remarks/>
        public SqlTransactionType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlTransaction")]
    public enum SqlTransactionType {
        
        /// <remarks/>
        Begin,
        
        /// <remarks/>
        Commit,
        
        /// <remarks/>
        Rollback,
        
        /// <remarks/>
        EnlistDTC,
        
        /// <remarks/>
        Defect,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sqlserver/2004/SOAP/types/SqlRowCount")]
    public partial class SqlRowCount {
        
        private long countField;
        
        /// <remarks/>
        public long Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void GetEmployeesCompletedEventHandler(object sender, GetEmployeesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591