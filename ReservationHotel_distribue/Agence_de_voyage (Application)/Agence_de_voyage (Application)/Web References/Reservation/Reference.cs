﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Agence_de_voyage__Application_.Reservation {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Reservation_HotelSoap", Namespace="http://tempuri.org/")]
    public partial class Reservation_Hotel : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VerificationAgencePartenaireOperationCompleted;
        
        private System.Threading.SendOrPostCallback traitementReservationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Reservation_Hotel() {
            this.Url = global::Agence_de_voyage__Application_.Properties.Settings.Default.Agence_de_voyage__Application__Reservation_Reservation_Hotel;
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
        public event VerificationAgencePartenaireCompletedEventHandler VerificationAgencePartenaireCompleted;
        
        /// <remarks/>
        public event traitementReservationCompletedEventHandler traitementReservationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/VerificationAgencePartenaire", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Msg VerificationAgencePartenaire(string idAgence, string password) {
            object[] results = this.Invoke("VerificationAgencePartenaire", new object[] {
                        idAgence,
                        password});
            return ((Msg)(results[0]));
        }
        
        /// <remarks/>
        public void VerificationAgencePartenaireAsync(string idAgence, string password) {
            this.VerificationAgencePartenaireAsync(idAgence, password, null);
        }
        
        /// <remarks/>
        public void VerificationAgencePartenaireAsync(string idAgence, string password, object userState) {
            if ((this.VerificationAgencePartenaireOperationCompleted == null)) {
                this.VerificationAgencePartenaireOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVerificationAgencePartenaireOperationCompleted);
            }
            this.InvokeAsync("VerificationAgencePartenaire", new object[] {
                        idAgence,
                        password}, this.VerificationAgencePartenaireOperationCompleted, userState);
        }
        
        private void OnVerificationAgencePartenaireOperationCompleted(object arg) {
            if ((this.VerificationAgencePartenaireCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VerificationAgencePartenaireCompleted(this, new VerificationAgencePartenaireCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/traitementReservation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Reservation traitementReservation(string nom, string prenom, string carteBancaire, string id, string nbPersonne, double nbNuit) {
            object[] results = this.Invoke("traitementReservation", new object[] {
                        nom,
                        prenom,
                        carteBancaire,
                        id,
                        nbPersonne,
                        nbNuit});
            return ((Reservation)(results[0]));
        }
        
        /// <remarks/>
        public void traitementReservationAsync(string nom, string prenom, string carteBancaire, string id, string nbPersonne, double nbNuit) {
            this.traitementReservationAsync(nom, prenom, carteBancaire, id, nbPersonne, nbNuit, null);
        }
        
        /// <remarks/>
        public void traitementReservationAsync(string nom, string prenom, string carteBancaire, string id, string nbPersonne, double nbNuit, object userState) {
            if ((this.traitementReservationOperationCompleted == null)) {
                this.traitementReservationOperationCompleted = new System.Threading.SendOrPostCallback(this.OntraitementReservationOperationCompleted);
            }
            this.InvokeAsync("traitementReservation", new object[] {
                        nom,
                        prenom,
                        carteBancaire,
                        id,
                        nbPersonne,
                        nbNuit}, this.traitementReservationOperationCompleted, userState);
        }
        
        private void OntraitementReservationOperationCompleted(object arg) {
            if ((this.traitementReservationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.traitementReservationCompleted(this, new traitementReservationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Msg {
        
        private string msgField;
        
        private int codeField;
        
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
        public int code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Client {
        
        private string nomField;
        
        private string prenomField;
        
        private string carteBancaireField;
        
        /// <remarks/>
        public string nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
            }
        }
        
        /// <remarks/>
        public string prenom {
            get {
                return this.prenomField;
            }
            set {
                this.prenomField = value;
            }
        }
        
        /// <remarks/>
        public string carteBancaire {
            get {
                return this.carteBancaireField;
            }
            set {
                this.carteBancaireField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Reservation {
        
        private Client clientField;
        
        private string idReservationField;
        
        private string nbPersonneField;
        
        private double nbNuitField;
        
        private string recapitulatifField;
        
        /// <remarks/>
        public Client client {
            get {
                return this.clientField;
            }
            set {
                this.clientField = value;
            }
        }
        
        /// <remarks/>
        public string idReservation {
            get {
                return this.idReservationField;
            }
            set {
                this.idReservationField = value;
            }
        }
        
        /// <remarks/>
        public string nbPersonne {
            get {
                return this.nbPersonneField;
            }
            set {
                this.nbPersonneField = value;
            }
        }
        
        /// <remarks/>
        public double nbNuit {
            get {
                return this.nbNuitField;
            }
            set {
                this.nbNuitField = value;
            }
        }
        
        /// <remarks/>
        public string recapitulatif {
            get {
                return this.recapitulatifField;
            }
            set {
                this.recapitulatifField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void VerificationAgencePartenaireCompletedEventHandler(object sender, VerificationAgencePartenaireCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VerificationAgencePartenaireCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VerificationAgencePartenaireCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Msg Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Msg)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void traitementReservationCompletedEventHandler(object sender, traitementReservationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class traitementReservationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal traitementReservationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Reservation Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Reservation)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591