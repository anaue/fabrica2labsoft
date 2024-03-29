﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3082.
// 
#pragma warning disable 1591

namespace InterfaceUsuario.ServicoUsuario {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicoUsuarioSoap", Namespace="http://www.pece.org.br/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseResponse))]
    public partial class ServicoUsuario : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CriarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeletarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback AlterarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscaUsuariosOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServicoUsuario() {
            this.Url = global::InterfaceUsuario.Properties.Settings.Default.InterfaceUsuario_ServicoUsuario_ServicoUsuario;
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
        public event CriarUsuarioCompletedEventHandler CriarUsuarioCompleted;
        
        /// <remarks/>
        public event DeletarUsuarioCompletedEventHandler DeletarUsuarioCompleted;
        
        /// <remarks/>
        public event AlterarUsuarioCompletedEventHandler AlterarUsuarioCompleted;
        
        /// <remarks/>
        public event ConsultarUsuarioCompletedEventHandler ConsultarUsuarioCompleted;
        
        /// <remarks/>
        public event BuscaUsuariosCompletedEventHandler BuscaUsuariosCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.pece.org.br/CriaUsuario", RequestElementName="CriaUsuario", RequestNamespace="http://www.pece.org.br/", ResponseElementName="CriaUsuarioResponse", ResponseNamespace="http://www.pece.org.br/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ResponseUsuario", IsNullable=true)]
        public ResponseUsuario CriarUsuario([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RequestUsuario RequestUsuario) {
            object[] results = this.Invoke("CriarUsuario", new object[] {
                        RequestUsuario});
            return ((ResponseUsuario)(results[0]));
        }
        
        /// <remarks/>
        public void CriarUsuarioAsync(RequestUsuario RequestUsuario) {
            this.CriarUsuarioAsync(RequestUsuario, null);
        }
        
        /// <remarks/>
        public void CriarUsuarioAsync(RequestUsuario RequestUsuario, object userState) {
            if ((this.CriarUsuarioOperationCompleted == null)) {
                this.CriarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCriarUsuarioOperationCompleted);
            }
            this.InvokeAsync("CriarUsuario", new object[] {
                        RequestUsuario}, this.CriarUsuarioOperationCompleted, userState);
        }
        
        private void OnCriarUsuarioOperationCompleted(object arg) {
            if ((this.CriarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CriarUsuarioCompleted(this, new CriarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.pece.org.br/DeletaUsuario", RequestElementName="DeletaUsuario", RequestNamespace="http://www.pece.org.br/", ResponseElementName="DeletaUsuarioResponse", ResponseNamespace="http://www.pece.org.br/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ResponseUsuario", IsNullable=true)]
        public ResponseUsuario DeletarUsuario([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RequestUsuario RequestUsuario) {
            object[] results = this.Invoke("DeletarUsuario", new object[] {
                        RequestUsuario});
            return ((ResponseUsuario)(results[0]));
        }
        
        /// <remarks/>
        public void DeletarUsuarioAsync(RequestUsuario RequestUsuario) {
            this.DeletarUsuarioAsync(RequestUsuario, null);
        }
        
        /// <remarks/>
        public void DeletarUsuarioAsync(RequestUsuario RequestUsuario, object userState) {
            if ((this.DeletarUsuarioOperationCompleted == null)) {
                this.DeletarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeletarUsuarioOperationCompleted);
            }
            this.InvokeAsync("DeletarUsuario", new object[] {
                        RequestUsuario}, this.DeletarUsuarioOperationCompleted, userState);
        }
        
        private void OnDeletarUsuarioOperationCompleted(object arg) {
            if ((this.DeletarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeletarUsuarioCompleted(this, new DeletarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.pece.org.br/AlteraUsuario", RequestElementName="AlteraUsuario", RequestNamespace="http://www.pece.org.br/", ResponseElementName="AlteraUsuarioResponse", ResponseNamespace="http://www.pece.org.br/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ResponseUsuario", IsNullable=true)]
        public ResponseUsuario AlterarUsuario([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RequestUsuario RequestUsuario) {
            object[] results = this.Invoke("AlterarUsuario", new object[] {
                        RequestUsuario});
            return ((ResponseUsuario)(results[0]));
        }
        
        /// <remarks/>
        public void AlterarUsuarioAsync(RequestUsuario RequestUsuario) {
            this.AlterarUsuarioAsync(RequestUsuario, null);
        }
        
        /// <remarks/>
        public void AlterarUsuarioAsync(RequestUsuario RequestUsuario, object userState) {
            if ((this.AlterarUsuarioOperationCompleted == null)) {
                this.AlterarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAlterarUsuarioOperationCompleted);
            }
            this.InvokeAsync("AlterarUsuario", new object[] {
                        RequestUsuario}, this.AlterarUsuarioOperationCompleted, userState);
        }
        
        private void OnAlterarUsuarioOperationCompleted(object arg) {
            if ((this.AlterarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AlterarUsuarioCompleted(this, new AlterarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.pece.org.br/ConsultaUsuario", RequestElementName="ConsultaUsuario", RequestNamespace="http://www.pece.org.br/", ResponseElementName="ConsultaUsuarioResponse", ResponseNamespace="http://www.pece.org.br/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ResponseUsuario", IsNullable=true)]
        public ResponseUsuario ConsultarUsuario([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RequestUsuario RequestUsuario) {
            object[] results = this.Invoke("ConsultarUsuario", new object[] {
                        RequestUsuario});
            return ((ResponseUsuario)(results[0]));
        }
        
        /// <remarks/>
        public void ConsultarUsuarioAsync(RequestUsuario RequestUsuario) {
            this.ConsultarUsuarioAsync(RequestUsuario, null);
        }
        
        /// <remarks/>
        public void ConsultarUsuarioAsync(RequestUsuario RequestUsuario, object userState) {
            if ((this.ConsultarUsuarioOperationCompleted == null)) {
                this.ConsultarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultarUsuarioOperationCompleted);
            }
            this.InvokeAsync("ConsultarUsuario", new object[] {
                        RequestUsuario}, this.ConsultarUsuarioOperationCompleted, userState);
        }
        
        private void OnConsultarUsuarioOperationCompleted(object arg) {
            if ((this.ConsultarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultarUsuarioCompleted(this, new ConsultarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.pece.org.br/BuscaUsuarios", RequestNamespace="http://www.pece.org.br/", ResponseNamespace="http://www.pece.org.br/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ResponseUsuario", IsNullable=true)]
        public ResponseUsuario BuscaUsuarios([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] RequestUsuario RequestUsuario) {
            object[] results = this.Invoke("BuscaUsuarios", new object[] {
                        RequestUsuario});
            return ((ResponseUsuario)(results[0]));
        }
        
        /// <remarks/>
        public void BuscaUsuariosAsync(RequestUsuario RequestUsuario) {
            this.BuscaUsuariosAsync(RequestUsuario, null);
        }
        
        /// <remarks/>
        public void BuscaUsuariosAsync(RequestUsuario RequestUsuario, object userState) {
            if ((this.BuscaUsuariosOperationCompleted == null)) {
                this.BuscaUsuariosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscaUsuariosOperationCompleted);
            }
            this.InvokeAsync("BuscaUsuarios", new object[] {
                        RequestUsuario}, this.BuscaUsuariosOperationCompleted, userState);
        }
        
        private void OnBuscaUsuariosOperationCompleted(object arg) {
            if ((this.BuscaUsuariosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscaUsuariosCompleted(this, new BuscaUsuariosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pece.org.br/")]
    public partial class RequestUsuario {
        
        private int idUsuarioField;
        
        private Usuario usuarioField;
        
        /// <remarks/>
        public int idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Usuario Usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pece.org.br/")]
    public partial class Usuario {
        
        private int idField;
        
        private int tipoUsuarioField;
        
        private string nomeField;
        
        private string senhaField;
        
        private string descricaoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int TipoUsuario {
            get {
                return this.tipoUsuarioField;
            }
            set {
                this.tipoUsuarioField = value;
            }
        }
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string Senha {
            get {
                return this.senhaField;
            }
            set {
                this.senhaField = value;
            }
        }
        
        /// <remarks/>
        public string Descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseUsuario))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pece.org.br/")]
    public partial class BaseResponse {
        
        private ResponseStatus statusCodeField;
        
        private string messageField;
        
        /// <remarks/>
        public ResponseStatus StatusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pece.org.br/")]
    public enum ResponseStatus {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Continue,
        
        /// <remarks/>
        OK,
        
        /// <remarks/>
        Created,
        
        /// <remarks/>
        Accepted,
        
        /// <remarks/>
        NoContent,
        
        /// <remarks/>
        MovedPermanently,
        
        /// <remarks/>
        Found,
        
        /// <remarks/>
        SeeOther,
        
        /// <remarks/>
        NotModified,
        
        /// <remarks/>
        BadRequest,
        
        /// <remarks/>
        Unauthorized,
        
        /// <remarks/>
        Forbidden,
        
        /// <remarks/>
        NotFound,
        
        /// <remarks/>
        MethodNotAllowed,
        
        /// <remarks/>
        RequestTimeout,
        
        /// <remarks/>
        Conflict,
        
        /// <remarks/>
        NotImplemented,
        
        /// <remarks/>
        ServiceUnavailable,
        
        /// <remarks/>
        BadVersion,
        
        /// <remarks/>
        InternalServerError,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pece.org.br/")]
    public partial class ResponseUsuario : BaseResponse {
        
        private Usuario usuarioField;
        
        private bool boolUsuarioField;
        
        private int idField;
        
        private Usuario[] listaUsuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Usuario Usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
            }
        }
        
        /// <remarks/>
        public bool BoolUsuario {
            get {
                return this.boolUsuarioField;
            }
            set {
                this.boolUsuarioField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListaUsuario", IsNullable=true)]
        public Usuario[] ListaUsuario {
            get {
                return this.listaUsuarioField;
            }
            set {
                this.listaUsuarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void CriarUsuarioCompletedEventHandler(object sender, CriarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CriarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CriarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseUsuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseUsuario)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeletarUsuarioCompletedEventHandler(object sender, DeletarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeletarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeletarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseUsuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseUsuario)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void AlterarUsuarioCompletedEventHandler(object sender, AlterarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AlterarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AlterarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseUsuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseUsuario)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void ConsultarUsuarioCompletedEventHandler(object sender, ConsultarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseUsuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseUsuario)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void BuscaUsuariosCompletedEventHandler(object sender, BuscaUsuariosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscaUsuariosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscaUsuariosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ResponseUsuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ResponseUsuario)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591