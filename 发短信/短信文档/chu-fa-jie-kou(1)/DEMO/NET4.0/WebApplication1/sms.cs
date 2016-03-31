﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1008
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// 此源代码由 wsdl 自动生成, Version=4.0.30319.1。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="smsSoap", Namespace="http://121.199.16.178/")]
public partial class sms : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback SubmitOperationCompleted;
    
    private System.Threading.SendOrPostCallback ChangePasswordOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetNumOperationCompleted;
    
    private System.Threading.SendOrPostCallback VersionInfoOperationCompleted;
    
    /// <remarks/>
    public sms() {
        this.Url = "http://121.199.16.178/webservice/sms.php?smsService";
    }
    
    /// <remarks/>
    public event SubmitCompletedEventHandler SubmitCompleted;
    
    /// <remarks/>
    public event ChangePasswordCompletedEventHandler ChangePasswordCompleted;
    
    /// <remarks/>
    public event GetNumCompletedEventHandler GetNumCompleted;
    
    /// <remarks/>
    public event VersionInfoCompletedEventHandler VersionInfoCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.xmlsoap.org/Submit", RequestNamespace="http://121.199.16.178/", ResponseNamespace="http://121.199.16.178/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public SubmitResult Submit(string account, string password, string mobile, string content) {
        object[] results = this.Invoke("Submit", new object[] {
                    account,
                    password,
                    mobile,
                    content});
        return ((SubmitResult)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSubmit(string account, string password, string mobile, string content, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Submit", new object[] {
                    account,
                    password,
                    mobile,
                    content}, callback, asyncState);
    }
    
    /// <remarks/>
    public SubmitResult EndSubmit(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((SubmitResult)(results[0]));
    }
    
    /// <remarks/>
    public void SubmitAsync(string account, string password, string mobile, string content) {
        this.SubmitAsync(account, password, mobile, content, null);
    }
    
    /// <remarks/>
    public void SubmitAsync(string account, string password, string mobile, string content, object userState) {
        if ((this.SubmitOperationCompleted == null)) {
            this.SubmitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitOperationCompleted);
        }
        this.InvokeAsync("Submit", new object[] {
                    account,
                    password,
                    mobile,
                    content}, this.SubmitOperationCompleted, userState);
    }
    
    private void OnSubmitOperationCompleted(object arg) {
        if ((this.SubmitCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SubmitCompleted(this, new SubmitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.xmlsoap.org/ChangePassword", RequestNamespace="http://121.199.16.178/", ResponseNamespace="http://121.199.16.178/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ChangePasswordResult ChangePassword(string account, string password, string newpassword) {
        object[] results = this.Invoke("ChangePassword", new object[] {
                    account,
                    password,
                    newpassword});
        return ((ChangePasswordResult)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginChangePassword(string account, string password, string newpassword, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ChangePassword", new object[] {
                    account,
                    password,
                    newpassword}, callback, asyncState);
    }
    
    /// <remarks/>
    public ChangePasswordResult EndChangePassword(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((ChangePasswordResult)(results[0]));
    }
    
    /// <remarks/>
    public void ChangePasswordAsync(string account, string password, string newpassword) {
        this.ChangePasswordAsync(account, password, newpassword, null);
    }
    
    /// <remarks/>
    public void ChangePasswordAsync(string account, string password, string newpassword, object userState) {
        if ((this.ChangePasswordOperationCompleted == null)) {
            this.ChangePasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangePasswordOperationCompleted);
        }
        this.InvokeAsync("ChangePassword", new object[] {
                    account,
                    password,
                    newpassword}, this.ChangePasswordOperationCompleted, userState);
    }
    
    private void OnChangePasswordOperationCompleted(object arg) {
        if ((this.ChangePasswordCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ChangePasswordCompleted(this, new ChangePasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.xmlsoap.org/GetNum", RequestNamespace="http://121.199.16.178/", ResponseNamespace="http://121.199.16.178/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public GetNumResult GetNum(string account, string password) {
        object[] results = this.Invoke("GetNum", new object[] {
                    account,
                    password});
        return ((GetNumResult)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetNum(string account, string password, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetNum", new object[] {
                    account,
                    password}, callback, asyncState);
    }
    
    /// <remarks/>
    public GetNumResult EndGetNum(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((GetNumResult)(results[0]));
    }
    
    /// <remarks/>
    public void GetNumAsync(string account, string password) {
        this.GetNumAsync(account, password, null);
    }
    
    /// <remarks/>
    public void GetNumAsync(string account, string password, object userState) {
        if ((this.GetNumOperationCompleted == null)) {
            this.GetNumOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetNumOperationCompleted);
        }
        this.InvokeAsync("GetNum", new object[] {
                    account,
                    password}, this.GetNumOperationCompleted, userState);
    }
    
    private void OnGetNumOperationCompleted(object arg) {
        if ((this.GetNumCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetNumCompleted(this, new GetNumCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.xmlsoap.org/VersionInfo", RequestNamespace="http://121.199.16.178/", ResponseNamespace="http://121.199.16.178/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public VersionInfoResult VersionInfo() {
        object[] results = this.Invoke("VersionInfo", new object[0]);
        return ((VersionInfoResult)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginVersionInfo(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("VersionInfo", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public VersionInfoResult EndVersionInfo(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((VersionInfoResult)(results[0]));
    }
    
    /// <remarks/>
    public void VersionInfoAsync() {
        this.VersionInfoAsync(null);
    }
    
    /// <remarks/>
    public void VersionInfoAsync(object userState) {
        if ((this.VersionInfoOperationCompleted == null)) {
            this.VersionInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVersionInfoOperationCompleted);
        }
        this.InvokeAsync("VersionInfo", new object[0], this.VersionInfoOperationCompleted, userState);
    }
    
    private void OnVersionInfoOperationCompleted(object arg) {
        if ((this.VersionInfoCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.VersionInfoCompleted(this, new VersionInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://121.199.16.178/")]
public partial class SubmitResult {
    
    private int codeField;
    
    private string msgField;
    
    private int smsidField;
    
    /// <remarks/>
    public int code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public string msg {
        get {
            return this.msgField;
        }
        set {
            this.msgField = value;
        }
    }
    
    /// <remarks/>
    public int smsid {
        get {
            return this.smsidField;
        }
        set {
            this.smsidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://121.199.16.178/")]
public partial class VersionInfoResult {
    
    private string msgField;
    
    /// <remarks/>
    public string msg {
        get {
            return this.msgField;
        }
        set {
            this.msgField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://121.199.16.178/")]
public partial class GetNumResult {
    
    private int codeField;
    
    private string msgField;
    
    private int numField;
    
    /// <remarks/>
    public int code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public string msg {
        get {
            return this.msgField;
        }
        set {
            this.msgField = value;
        }
    }
    
    /// <remarks/>
    public int num {
        get {
            return this.numField;
        }
        set {
            this.numField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://121.199.16.178/")]
public partial class ChangePasswordResult {
    
    private int codeField;
    
    private string msgField;
    
    /// <remarks/>
    public int code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public string msg {
        get {
            return this.msgField;
        }
        set {
            this.msgField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void SubmitCompletedEventHandler(object sender, SubmitCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SubmitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SubmitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public SubmitResult Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((SubmitResult)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void ChangePasswordCompletedEventHandler(object sender, ChangePasswordCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ChangePasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ChangePasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public ChangePasswordResult Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((ChangePasswordResult)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void GetNumCompletedEventHandler(object sender, GetNumCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetNumCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetNumCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public GetNumResult Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((GetNumResult)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
public delegate void VersionInfoCompletedEventHandler(object sender, VersionInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class VersionInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal VersionInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public VersionInfoResult Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((VersionInfoResult)(this.results[0]));
        }
    }
}
