﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.1
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Der Quellcode wurde automatisch mit Microsoft.VSDesigner generiert. Version 4.0.30319.1.
// 
#pragma warning disable 1591

namespace NME2_Server_Manager.Nme2WsAdmin {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Nme2WsBinding", Namespace="http://hfs-wgbw.is-a-chef.com/soap/Nme2Ws")]
    public partial class Nme2Ws : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SecServiceCheckAuthOperationCompleted;
        
        private System.Threading.SendOrPostCallback AdminMissionServiceSaveArrayMissionOperationCompleted;
        
        private System.Threading.SendOrPostCallback AdminMissionServiceDeleteArrayMissionOperationCompleted;
        
        private System.Threading.SendOrPostCallback AdminMissionObjectServiceSaveArrayMissionObjectOperationCompleted;
        
        private System.Threading.SendOrPostCallback AdminMissionObjectServiceDeleteArrayMissionObjectOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Nme2Ws() {
            this.Url = global::NME2_Server_Manager.Properties.Settings.Default.NME2_Server_Manager_Nme2WsAdmin_Nme2Ws;
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
        public event SecServiceCheckAuthCompletedEventHandler SecServiceCheckAuthCompleted;
        
        /// <remarks/>
        public event AdminMissionServiceSaveArrayMissionCompletedEventHandler AdminMissionServiceSaveArrayMissionCompleted;
        
        /// <remarks/>
        public event AdminMissionServiceDeleteArrayMissionCompletedEventHandler AdminMissionServiceDeleteArrayMissionCompleted;
        
        /// <remarks/>
        public event AdminMissionObjectServiceSaveArrayMissionObjectCompletedEventHandler AdminMissionObjectServiceSaveArrayMissionObjectCompleted;
        
        /// <remarks/>
        public event AdminMissionObjectServiceDeleteArrayMissionObjectCompletedEventHandler AdminMissionObjectServiceDeleteArrayMissionObjectCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:nme2#checkauth", RequestNamespace="urn:nme2", ResponseNamespace="urn:nme2")]
        [return: System.Xml.Serialization.SoapElementAttribute("return", DataType="integer")]
        public string SecServiceCheckAuth(string user, string pwd) {
            object[] results = this.Invoke("SecServiceCheckAuth", new object[] {
                        user,
                        pwd});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SecServiceCheckAuthAsync(string user, string pwd) {
            this.SecServiceCheckAuthAsync(user, pwd, null);
        }
        
        /// <remarks/>
        public void SecServiceCheckAuthAsync(string user, string pwd, object userState) {
            if ((this.SecServiceCheckAuthOperationCompleted == null)) {
                this.SecServiceCheckAuthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSecServiceCheckAuthOperationCompleted);
            }
            this.InvokeAsync("SecServiceCheckAuth", new object[] {
                        user,
                        pwd}, this.SecServiceCheckAuthOperationCompleted, userState);
        }
        
        private void OnSecServiceCheckAuthOperationCompleted(object arg) {
            if ((this.SecServiceCheckAuthCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SecServiceCheckAuthCompleted(this, new SecServiceCheckAuthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:nme2#savearraymission", RequestNamespace="urn:nme2", ResponseNamespace="urn:nme2")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public Mission AdminMissionServiceSaveArrayMission(Mission mission, string user, string pwd) {
            object[] results = this.Invoke("AdminMissionServiceSaveArrayMission", new object[] {
                        mission,
                        user,
                        pwd});
            return ((Mission)(results[0]));
        }
        
        /// <remarks/>
        public void AdminMissionServiceSaveArrayMissionAsync(Mission mission, string user, string pwd) {
            this.AdminMissionServiceSaveArrayMissionAsync(mission, user, pwd, null);
        }
        
        /// <remarks/>
        public void AdminMissionServiceSaveArrayMissionAsync(Mission mission, string user, string pwd, object userState) {
            if ((this.AdminMissionServiceSaveArrayMissionOperationCompleted == null)) {
                this.AdminMissionServiceSaveArrayMissionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdminMissionServiceSaveArrayMissionOperationCompleted);
            }
            this.InvokeAsync("AdminMissionServiceSaveArrayMission", new object[] {
                        mission,
                        user,
                        pwd}, this.AdminMissionServiceSaveArrayMissionOperationCompleted, userState);
        }
        
        private void OnAdminMissionServiceSaveArrayMissionOperationCompleted(object arg) {
            if ((this.AdminMissionServiceSaveArrayMissionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AdminMissionServiceSaveArrayMissionCompleted(this, new AdminMissionServiceSaveArrayMissionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:nme2#deletearraymission", RequestNamespace="urn:nme2", ResponseNamespace="urn:nme2")]
        public void AdminMissionServiceDeleteArrayMission(Mission mission, string user, string pwd) {
            this.Invoke("AdminMissionServiceDeleteArrayMission", new object[] {
                        mission,
                        user,
                        pwd});
        }
        
        /// <remarks/>
        public void AdminMissionServiceDeleteArrayMissionAsync(Mission mission, string user, string pwd) {
            this.AdminMissionServiceDeleteArrayMissionAsync(mission, user, pwd, null);
        }
        
        /// <remarks/>
        public void AdminMissionServiceDeleteArrayMissionAsync(Mission mission, string user, string pwd, object userState) {
            if ((this.AdminMissionServiceDeleteArrayMissionOperationCompleted == null)) {
                this.AdminMissionServiceDeleteArrayMissionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdminMissionServiceDeleteArrayMissionOperationCompleted);
            }
            this.InvokeAsync("AdminMissionServiceDeleteArrayMission", new object[] {
                        mission,
                        user,
                        pwd}, this.AdminMissionServiceDeleteArrayMissionOperationCompleted, userState);
        }
        
        private void OnAdminMissionServiceDeleteArrayMissionOperationCompleted(object arg) {
            if ((this.AdminMissionServiceDeleteArrayMissionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AdminMissionServiceDeleteArrayMissionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:nme2#savearraymissionobject", RequestNamespace="urn:nme2", ResponseNamespace="urn:nme2")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public Mission AdminMissionObjectServiceSaveArrayMissionObject(MissionObject missionObject, string user, string pwd) {
            object[] results = this.Invoke("AdminMissionObjectServiceSaveArrayMissionObject", new object[] {
                        missionObject,
                        user,
                        pwd});
            return ((Mission)(results[0]));
        }
        
        /// <remarks/>
        public void AdminMissionObjectServiceSaveArrayMissionObjectAsync(MissionObject missionObject, string user, string pwd) {
            this.AdminMissionObjectServiceSaveArrayMissionObjectAsync(missionObject, user, pwd, null);
        }
        
        /// <remarks/>
        public void AdminMissionObjectServiceSaveArrayMissionObjectAsync(MissionObject missionObject, string user, string pwd, object userState) {
            if ((this.AdminMissionObjectServiceSaveArrayMissionObjectOperationCompleted == null)) {
                this.AdminMissionObjectServiceSaveArrayMissionObjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdminMissionObjectServiceSaveArrayMissionObjectOperationCompleted);
            }
            this.InvokeAsync("AdminMissionObjectServiceSaveArrayMissionObject", new object[] {
                        missionObject,
                        user,
                        pwd}, this.AdminMissionObjectServiceSaveArrayMissionObjectOperationCompleted, userState);
        }
        
        private void OnAdminMissionObjectServiceSaveArrayMissionObjectOperationCompleted(object arg) {
            if ((this.AdminMissionObjectServiceSaveArrayMissionObjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AdminMissionObjectServiceSaveArrayMissionObjectCompleted(this, new AdminMissionObjectServiceSaveArrayMissionObjectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:nme2#deletearraymissionobject", RequestNamespace="urn:nme2", ResponseNamespace="urn:nme2")]
        public void AdminMissionObjectServiceDeleteArrayMissionObject(MissionObject missionObject, string user, string pwd) {
            this.Invoke("AdminMissionObjectServiceDeleteArrayMissionObject", new object[] {
                        missionObject,
                        user,
                        pwd});
        }
        
        /// <remarks/>
        public void AdminMissionObjectServiceDeleteArrayMissionObjectAsync(MissionObject missionObject, string user, string pwd) {
            this.AdminMissionObjectServiceDeleteArrayMissionObjectAsync(missionObject, user, pwd, null);
        }
        
        /// <remarks/>
        public void AdminMissionObjectServiceDeleteArrayMissionObjectAsync(MissionObject missionObject, string user, string pwd, object userState) {
            if ((this.AdminMissionObjectServiceDeleteArrayMissionObjectOperationCompleted == null)) {
                this.AdminMissionObjectServiceDeleteArrayMissionObjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdminMissionObjectServiceDeleteArrayMissionObjectOperationCompleted);
            }
            this.InvokeAsync("AdminMissionObjectServiceDeleteArrayMissionObject", new object[] {
                        missionObject,
                        user,
                        pwd}, this.AdminMissionObjectServiceDeleteArrayMissionObjectOperationCompleted, userState);
        }
        
        private void OnAdminMissionObjectServiceDeleteArrayMissionObjectOperationCompleted(object arg) {
            if ((this.AdminMissionObjectServiceDeleteArrayMissionObjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AdminMissionObjectServiceDeleteArrayMissionObjectCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://hfs-wgbw.is-a-chef.com/soap/Nme2Ws")]
    public partial class Mission {
        
        private int idField;
        
        private string nameField;
        
        private string versionField;
        
        private double centerLatField;
        
        private double centerLonField;
        
        private int missionRangeField;
        
        private int activeField;
        
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
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public double CenterLat {
            get {
                return this.centerLatField;
            }
            set {
                this.centerLatField = value;
            }
        }
        
        /// <remarks/>
        public double CenterLon {
            get {
                return this.centerLonField;
            }
            set {
                this.centerLonField = value;
            }
        }
        
        /// <remarks/>
        public int MissionRange {
            get {
                return this.missionRangeField;
            }
            set {
                this.missionRangeField = value;
            }
        }
        
        /// <remarks/>
        public int Active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://hfs-wgbw.is-a-chef.com/soap/Nme2Ws")]
    public partial class SimObject {
        
        private int idField;
        
        private string nameField;
        
        private string simNameField;
        
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
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string SimName {
            get {
                return this.simNameField;
            }
            set {
                this.simNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://hfs-wgbw.is-a-chef.com/soap/Nme2Ws")]
    public partial class MissionObject {
        
        private int idField;
        
        private int mission_IdField;
        
        private Mission missionField;
        
        private int simObject_IdField;
        
        private SimObject simobjectField;
        
        private double latField;
        
        private double lonField;
        
        private float altitudeField;
        
        private int onGroundField;
        
        private double pitchField;
        
        private double yawField;
        
        private double bankField;
        
        private int headingField;
        
        private int activeField;
        
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
        public int Mission_Id {
            get {
                return this.mission_IdField;
            }
            set {
                this.mission_IdField = value;
            }
        }
        
        /// <remarks/>
        public Mission Mission {
            get {
                return this.missionField;
            }
            set {
                this.missionField = value;
            }
        }
        
        /// <remarks/>
        public int SimObject_Id {
            get {
                return this.simObject_IdField;
            }
            set {
                this.simObject_IdField = value;
            }
        }
        
        /// <remarks/>
        public SimObject Simobject {
            get {
                return this.simobjectField;
            }
            set {
                this.simobjectField = value;
            }
        }
        
        /// <remarks/>
        public double Lat {
            get {
                return this.latField;
            }
            set {
                this.latField = value;
            }
        }
        
        /// <remarks/>
        public double Lon {
            get {
                return this.lonField;
            }
            set {
                this.lonField = value;
            }
        }
        
        /// <remarks/>
        public float Altitude {
            get {
                return this.altitudeField;
            }
            set {
                this.altitudeField = value;
            }
        }
        
        /// <remarks/>
        public int OnGround {
            get {
                return this.onGroundField;
            }
            set {
                this.onGroundField = value;
            }
        }
        
        /// <remarks/>
        public double Pitch {
            get {
                return this.pitchField;
            }
            set {
                this.pitchField = value;
            }
        }
        
        /// <remarks/>
        public double Yaw {
            get {
                return this.yawField;
            }
            set {
                this.yawField = value;
            }
        }
        
        /// <remarks/>
        public double Bank {
            get {
                return this.bankField;
            }
            set {
                this.bankField = value;
            }
        }
        
        /// <remarks/>
        public int Heading {
            get {
                return this.headingField;
            }
            set {
                this.headingField = value;
            }
        }
        
        /// <remarks/>
        public int Active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SecServiceCheckAuthCompletedEventHandler(object sender, SecServiceCheckAuthCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SecServiceCheckAuthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SecServiceCheckAuthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AdminMissionServiceSaveArrayMissionCompletedEventHandler(object sender, AdminMissionServiceSaveArrayMissionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AdminMissionServiceSaveArrayMissionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AdminMissionServiceSaveArrayMissionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Mission Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Mission)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AdminMissionServiceDeleteArrayMissionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AdminMissionObjectServiceSaveArrayMissionObjectCompletedEventHandler(object sender, AdminMissionObjectServiceSaveArrayMissionObjectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AdminMissionObjectServiceSaveArrayMissionObjectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AdminMissionObjectServiceSaveArrayMissionObjectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Mission Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Mission)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AdminMissionObjectServiceDeleteArrayMissionObjectCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591