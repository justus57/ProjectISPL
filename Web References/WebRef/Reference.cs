//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Project1.WebRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PESALinkTransfer_Binding", Namespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer")]
    public partial class PESALinkTransfer : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetEntryToTransferOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateTransferStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEntryToSeekStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetISODescriptionOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckValidAccountDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertDepositEntryOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEntryToSeekDepositStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateDepositStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback PostPESALinkDepositsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PESALinkTransfer() {
            this.Url = global::Project1.Properties.Settings.Default.Project1_WebRef_PESALinkTransfer;
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
        public event GetEntryToTransferCompletedEventHandler GetEntryToTransferCompleted;
        
        /// <remarks/>
        public event UpdateTransferStatusCompletedEventHandler UpdateTransferStatusCompleted;
        
        /// <remarks/>
        public event GetEntryToSeekStatusCompletedEventHandler GetEntryToSeekStatusCompleted;
        
        /// <remarks/>
        public event GetISODescriptionCompletedEventHandler GetISODescriptionCompleted;
        
        /// <remarks/>
        public event CheckValidAccountDetailsCompletedEventHandler CheckValidAccountDetailsCompleted;
        
        /// <remarks/>
        public event InsertDepositEntryCompletedEventHandler InsertDepositEntryCompleted;
        
        /// <remarks/>
        public event GetEntryToSeekDepositStatusCompletedEventHandler GetEntryToSeekDepositStatusCompleted;
        
        /// <remarks/>
        public event UpdateDepositStatusCompletedEventHandler UpdateDepositStatusCompleted;
        
        /// <remarks/>
        public event PostPESALinkDepositsCompletedEventHandler PostPESALinkDepositsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:GetEntryToTransfer", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="GetEntryToTransfer_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string GetEntryToTransfer() {
            object[] results = this.Invoke("GetEntryToTransfer", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetEntryToTransferAsync() {
            this.GetEntryToTransferAsync(null);
        }
        
        /// <remarks/>
        public void GetEntryToTransferAsync(object userState) {
            if ((this.GetEntryToTransferOperationCompleted == null)) {
                this.GetEntryToTransferOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEntryToTransferOperationCompleted);
            }
            this.InvokeAsync("GetEntryToTransfer", new object[0], this.GetEntryToTransferOperationCompleted, userState);
        }
        
        private void OnGetEntryToTransferOperationCompleted(object arg) {
            if ((this.GetEntryToTransferCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEntryToTransferCompleted(this, new GetEntryToTransferCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:UpdateTransferStatus", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="UpdateTransferStatus_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string UpdateTransferStatus(string requestID, string statusOfRequestCode) {
            object[] results = this.Invoke("UpdateTransferStatus", new object[] {
                        requestID,
                        statusOfRequestCode});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateTransferStatusAsync(string requestID, string statusOfRequestCode) {
            this.UpdateTransferStatusAsync(requestID, statusOfRequestCode, null);
        }
        
        /// <remarks/>
        public void UpdateTransferStatusAsync(string requestID, string statusOfRequestCode, object userState) {
            if ((this.UpdateTransferStatusOperationCompleted == null)) {
                this.UpdateTransferStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateTransferStatusOperationCompleted);
            }
            this.InvokeAsync("UpdateTransferStatus", new object[] {
                        requestID,
                        statusOfRequestCode}, this.UpdateTransferStatusOperationCompleted, userState);
        }
        
        private void OnUpdateTransferStatusOperationCompleted(object arg) {
            if ((this.UpdateTransferStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateTransferStatusCompleted(this, new UpdateTransferStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:GetEntryToSeekStatus", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="GetEntryToSeekStatus_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string GetEntryToSeekStatus() {
            object[] results = this.Invoke("GetEntryToSeekStatus", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetEntryToSeekStatusAsync() {
            this.GetEntryToSeekStatusAsync(null);
        }
        
        /// <remarks/>
        public void GetEntryToSeekStatusAsync(object userState) {
            if ((this.GetEntryToSeekStatusOperationCompleted == null)) {
                this.GetEntryToSeekStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEntryToSeekStatusOperationCompleted);
            }
            this.InvokeAsync("GetEntryToSeekStatus", new object[0], this.GetEntryToSeekStatusOperationCompleted, userState);
        }
        
        private void OnGetEntryToSeekStatusOperationCompleted(object arg) {
            if ((this.GetEntryToSeekStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEntryToSeekStatusCompleted(this, new GetEntryToSeekStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:GetISODescription", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="GetISODescription_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string GetISODescription(string actionCode) {
            object[] results = this.Invoke("GetISODescription", new object[] {
                        actionCode});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetISODescriptionAsync(string actionCode) {
            this.GetISODescriptionAsync(actionCode, null);
        }
        
        /// <remarks/>
        public void GetISODescriptionAsync(string actionCode, object userState) {
            if ((this.GetISODescriptionOperationCompleted == null)) {
                this.GetISODescriptionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetISODescriptionOperationCompleted);
            }
            this.InvokeAsync("GetISODescription", new object[] {
                        actionCode}, this.GetISODescriptionOperationCompleted, userState);
        }
        
        private void OnGetISODescriptionOperationCompleted(object arg) {
            if ((this.GetISODescriptionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetISODescriptionCompleted(this, new GetISODescriptionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:CheckValidAccountDetails" +
            "", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="CheckValidAccountDetails_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string CheckValidAccountDetails(string accountNo) {
            object[] results = this.Invoke("CheckValidAccountDetails", new object[] {
                        accountNo});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CheckValidAccountDetailsAsync(string accountNo) {
            this.CheckValidAccountDetailsAsync(accountNo, null);
        }
        
        /// <remarks/>
        public void CheckValidAccountDetailsAsync(string accountNo, object userState) {
            if ((this.CheckValidAccountDetailsOperationCompleted == null)) {
                this.CheckValidAccountDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckValidAccountDetailsOperationCompleted);
            }
            this.InvokeAsync("CheckValidAccountDetails", new object[] {
                        accountNo}, this.CheckValidAccountDetailsOperationCompleted, userState);
        }
        
        private void OnCheckValidAccountDetailsOperationCompleted(object arg) {
            if ((this.CheckValidAccountDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckValidAccountDetailsCompleted(this, new CheckValidAccountDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:InsertDepositEntry", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="InsertDepositEntry_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string InsertDepositEntry(string sourceReferenceNo, string sourceBankCode, string sourceAccountNo, string sourceAccountName, string purpose, string amountToTransfer, string destinationAccountNo) {
            object[] results = this.Invoke("InsertDepositEntry", new object[] {
                        sourceReferenceNo,
                        sourceBankCode,
                        sourceAccountNo,
                        sourceAccountName,
                        purpose,
                        amountToTransfer,
                        destinationAccountNo});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertDepositEntryAsync(string sourceReferenceNo, string sourceBankCode, string sourceAccountNo, string sourceAccountName, string purpose, string amountToTransfer, string destinationAccountNo) {
            this.InsertDepositEntryAsync(sourceReferenceNo, sourceBankCode, sourceAccountNo, sourceAccountName, purpose, amountToTransfer, destinationAccountNo, null);
        }
        
        /// <remarks/>
        public void InsertDepositEntryAsync(string sourceReferenceNo, string sourceBankCode, string sourceAccountNo, string sourceAccountName, string purpose, string amountToTransfer, string destinationAccountNo, object userState) {
            if ((this.InsertDepositEntryOperationCompleted == null)) {
                this.InsertDepositEntryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertDepositEntryOperationCompleted);
            }
            this.InvokeAsync("InsertDepositEntry", new object[] {
                        sourceReferenceNo,
                        sourceBankCode,
                        sourceAccountNo,
                        sourceAccountName,
                        purpose,
                        amountToTransfer,
                        destinationAccountNo}, this.InsertDepositEntryOperationCompleted, userState);
        }
        
        private void OnInsertDepositEntryOperationCompleted(object arg) {
            if ((this.InsertDepositEntryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertDepositEntryCompleted(this, new InsertDepositEntryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:GetEntryToSeekDepositSta" +
            "tus", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="GetEntryToSeekDepositStatus_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string GetEntryToSeekDepositStatus() {
            object[] results = this.Invoke("GetEntryToSeekDepositStatus", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetEntryToSeekDepositStatusAsync() {
            this.GetEntryToSeekDepositStatusAsync(null);
        }
        
        /// <remarks/>
        public void GetEntryToSeekDepositStatusAsync(object userState) {
            if ((this.GetEntryToSeekDepositStatusOperationCompleted == null)) {
                this.GetEntryToSeekDepositStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEntryToSeekDepositStatusOperationCompleted);
            }
            this.InvokeAsync("GetEntryToSeekDepositStatus", new object[0], this.GetEntryToSeekDepositStatusOperationCompleted, userState);
        }
        
        private void OnGetEntryToSeekDepositStatusOperationCompleted(object arg) {
            if ((this.GetEntryToSeekDepositStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEntryToSeekDepositStatusCompleted(this, new GetEntryToSeekDepositStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:UpdateDepositStatus", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="UpdateDepositStatus_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string UpdateDepositStatus(string entryNo, string sourceReferenceNo, string sourceBankCode, string sourceAccountNo, string amountToTransfer, string destinationAccountNo, string responseCode) {
            object[] results = this.Invoke("UpdateDepositStatus", new object[] {
                        entryNo,
                        sourceReferenceNo,
                        sourceBankCode,
                        sourceAccountNo,
                        amountToTransfer,
                        destinationAccountNo,
                        responseCode});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateDepositStatusAsync(string entryNo, string sourceReferenceNo, string sourceBankCode, string sourceAccountNo, string amountToTransfer, string destinationAccountNo, string responseCode) {
            this.UpdateDepositStatusAsync(entryNo, sourceReferenceNo, sourceBankCode, sourceAccountNo, amountToTransfer, destinationAccountNo, responseCode, null);
        }
        
        /// <remarks/>
        public void UpdateDepositStatusAsync(string entryNo, string sourceReferenceNo, string sourceBankCode, string sourceAccountNo, string amountToTransfer, string destinationAccountNo, string responseCode, object userState) {
            if ((this.UpdateDepositStatusOperationCompleted == null)) {
                this.UpdateDepositStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateDepositStatusOperationCompleted);
            }
            this.InvokeAsync("UpdateDepositStatus", new object[] {
                        entryNo,
                        sourceReferenceNo,
                        sourceBankCode,
                        sourceAccountNo,
                        amountToTransfer,
                        destinationAccountNo,
                        responseCode}, this.UpdateDepositStatusOperationCompleted, userState);
        }
        
        private void OnUpdateDepositStatusOperationCompleted(object arg) {
            if ((this.UpdateDepositStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateDepositStatusCompleted(this, new UpdateDepositStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer:PostPESALinkDeposits", RequestNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", ResponseElementName="PostPESALinkDeposits_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/codeunit/PESALinkTransfer", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return_value")]
        public string PostPESALinkDeposits() {
            object[] results = this.Invoke("PostPESALinkDeposits", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void PostPESALinkDepositsAsync() {
            this.PostPESALinkDepositsAsync(null);
        }
        
        /// <remarks/>
        public void PostPESALinkDepositsAsync(object userState) {
            if ((this.PostPESALinkDepositsOperationCompleted == null)) {
                this.PostPESALinkDepositsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPostPESALinkDepositsOperationCompleted);
            }
            this.InvokeAsync("PostPESALinkDeposits", new object[0], this.PostPESALinkDepositsOperationCompleted, userState);
        }
        
        private void OnPostPESALinkDepositsOperationCompleted(object arg) {
            if ((this.PostPESALinkDepositsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PostPESALinkDepositsCompleted(this, new PostPESALinkDepositsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEntryToTransferCompletedEventHandler(object sender, GetEntryToTransferCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEntryToTransferCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEntryToTransferCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void UpdateTransferStatusCompletedEventHandler(object sender, UpdateTransferStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateTransferStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateTransferStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEntryToSeekStatusCompletedEventHandler(object sender, GetEntryToSeekStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEntryToSeekStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEntryToSeekStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetISODescriptionCompletedEventHandler(object sender, GetISODescriptionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetISODescriptionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetISODescriptionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void CheckValidAccountDetailsCompletedEventHandler(object sender, CheckValidAccountDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckValidAccountDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckValidAccountDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void InsertDepositEntryCompletedEventHandler(object sender, InsertDepositEntryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertDepositEntryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertDepositEntryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetEntryToSeekDepositStatusCompletedEventHandler(object sender, GetEntryToSeekDepositStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEntryToSeekDepositStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEntryToSeekDepositStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void UpdateDepositStatusCompletedEventHandler(object sender, UpdateDepositStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateDepositStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateDepositStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void PostPESALinkDepositsCompletedEventHandler(object sender, PostPESALinkDepositsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PostPESALinkDepositsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PostPESALinkDepositsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591