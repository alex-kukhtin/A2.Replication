﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A2.Replication.Agent.ReplicationService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PackageData", Namespace="http://schemas.datacontract.org/2004/07/A2.Replication.Data")]
    [System.SerializableAttribute()]
    public partial class PackageData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasMoreDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NextPackageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<A2.Replication.Agent.ReplicationService.DataTable> TablesField;
        
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
        public bool HasContent {
            get {
                return this.HasContentField;
            }
            set {
                if ((this.HasContentField.Equals(value) != true)) {
                    this.HasContentField = value;
                    this.RaisePropertyChanged("HasContent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasMoreData {
            get {
                return this.HasMoreDataField;
            }
            set {
                if ((this.HasMoreDataField.Equals(value) != true)) {
                    this.HasMoreDataField = value;
                    this.RaisePropertyChanged("HasMoreData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((this.ItemIdField.Equals(value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemName {
            get {
                return this.ItemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemNameField, value) != true)) {
                    this.ItemNameField = value;
                    this.RaisePropertyChanged("ItemName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NextPackageId {
            get {
                return this.NextPackageIdField;
            }
            set {
                if ((this.NextPackageIdField.Equals(value) != true)) {
                    this.NextPackageIdField = value;
                    this.RaisePropertyChanged("NextPackageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<A2.Replication.Agent.ReplicationService.DataTable> Tables {
            get {
                return this.TablesField;
            }
            set {
                if ((object.ReferenceEquals(this.TablesField, value) != true)) {
                    this.TablesField = value;
                    this.RaisePropertyChanged("Tables");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataTable", Namespace="http://schemas.datacontract.org/2004/07/A2.Replication.Data")]
    [System.SerializableAttribute()]
    public partial class DataTable : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<A2.Replication.Agent.ReplicationService.DataColumn> ColumnsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<A2.Replication.Agent.ReplicationService.DataRow> RowsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TableNameField;
        
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
        public System.Collections.Generic.List<A2.Replication.Agent.ReplicationService.DataColumn> Columns {
            get {
                return this.ColumnsField;
            }
            set {
                if ((object.ReferenceEquals(this.ColumnsField, value) != true)) {
                    this.ColumnsField = value;
                    this.RaisePropertyChanged("Columns");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<A2.Replication.Agent.ReplicationService.DataRow> Rows {
            get {
                return this.RowsField;
            }
            set {
                if ((object.ReferenceEquals(this.RowsField, value) != true)) {
                    this.RowsField = value;
                    this.RaisePropertyChanged("Rows");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TableName {
            get {
                return this.TableNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TableNameField, value) != true)) {
                    this.TableNameField = value;
                    this.RaisePropertyChanged("TableName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataColumn", Namespace="http://schemas.datacontract.org/2004/07/A2.Replication.Data")]
    [System.SerializableAttribute()]
    public partial class DataColumn : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private A2.Replication.Agent.ReplicationService.SqlDbType DataTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public A2.Replication.Agent.ReplicationService.SqlDbType DataType {
            get {
                return this.DataTypeField;
            }
            set {
                if ((this.DataTypeField.Equals(value) != true)) {
                    this.DataTypeField = value;
                    this.RaisePropertyChanged("DataType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRow", Namespace="http://schemas.datacontract.org/2004/07/A2.Replication.Data")]
    [System.SerializableAttribute()]
    public partial class DataRow : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<string> ValuesField;
        
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
        public int Gen {
            get {
                return this.GenField;
            }
            set {
                if ((this.GenField.Equals(value) != true)) {
                    this.GenField = value;
                    this.RaisePropertyChanged("Gen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> Values {
            get {
                return this.ValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.ValuesField, value) != true)) {
                    this.ValuesField = value;
                    this.RaisePropertyChanged("Values");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SqlDbType", Namespace="http://schemas.datacontract.org/2004/07/System.Data")]
    public enum SqlDbType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BigInt = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Binary = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Bit = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Char = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DateTime = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Decimal = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Float = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Image = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Int = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Money = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NChar = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NText = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NVarChar = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Real = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UniqueIdentifier = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SmallDateTime = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SmallInt = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SmallMoney = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Text = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Timestamp = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TinyInt = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VarBinary = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VarChar = 22,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Variant = 23,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Xml = 25,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Udt = 29,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Structured = 30,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Date = 31,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Time = 32,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DateTime2 = 33,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DateTimeOffset = 34,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataForGet", Namespace="http://schemas.datacontract.org/2004/07/A2.Replication.Data")]
    [System.SerializableAttribute()]
    public partial class DataForGet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TableNameField;
        
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
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TableName {
            get {
                return this.TableNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TableNameField, value) != true)) {
                    this.TableNameField = value;
                    this.RaisePropertyChanged("TableName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReplicationService.IReplicationService")]
    public interface IReplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/StartSession", ReplyAction="http://tempuri.org/IReplicationService/StartSessionResponse")]
        long StartSession(long ClientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/EndSession", ReplyAction="http://tempuri.org/IReplicationService/EndSessionResponse")]
        void EndSession(long ClientId, long SessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/GetLastPackageId", ReplyAction="http://tempuri.org/IReplicationService/GetLastPackageIdResponse")]
        long GetLastPackageId(long ClientId, long SessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/LoadPackage", ReplyAction="http://tempuri.org/IReplicationService/LoadPackageResponse")]
        A2.Replication.Agent.ReplicationService.PackageData LoadPackage(long ClientId, long SessionId, long PackageId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/SendPackage", ReplyAction="http://tempuri.org/IReplicationService/SendPackageResponse")]
        void SendPackage(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.PackageData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/SendPackageContent", ReplyAction="http://tempuri.org/IReplicationService/SendPackageContentResponse")]
        void SendPackageContent(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.PackageData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/GetItemForGet", ReplyAction="http://tempuri.org/IReplicationService/GetItemForGetResponse")]
        A2.Replication.Agent.ReplicationService.DataForGet GetItemForGet(long ClientId, long SessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/GetDataForGet", ReplyAction="http://tempuri.org/IReplicationService/GetDataForGetResponse")]
        A2.Replication.Agent.ReplicationService.PackageData GetDataForGet(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.DataForGet DataForGet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReplicationService/SetDataForGetSent", ReplyAction="http://tempuri.org/IReplicationService/SetDataForGetSentResponse")]
        void SetDataForGetSent(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.DataForGet DataForGet);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReplicationServiceChannel : A2.Replication.Agent.ReplicationService.IReplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReplicationServiceClient : System.ServiceModel.ClientBase<A2.Replication.Agent.ReplicationService.IReplicationService>, A2.Replication.Agent.ReplicationService.IReplicationService {
        
        public ReplicationServiceClient() {
        }
        
        public ReplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long StartSession(long ClientId) {
            return base.Channel.StartSession(ClientId);
        }
        
        public void EndSession(long ClientId, long SessionId) {
            base.Channel.EndSession(ClientId, SessionId);
        }
        
        public long GetLastPackageId(long ClientId, long SessionId) {
            return base.Channel.GetLastPackageId(ClientId, SessionId);
        }
        
        public A2.Replication.Agent.ReplicationService.PackageData LoadPackage(long ClientId, long SessionId, long PackageId) {
            return base.Channel.LoadPackage(ClientId, SessionId, PackageId);
        }
        
        public void SendPackage(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.PackageData data) {
            base.Channel.SendPackage(ClientId, SessionId, data);
        }
        
        public void SendPackageContent(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.PackageData data) {
            base.Channel.SendPackageContent(ClientId, SessionId, data);
        }
        
        public A2.Replication.Agent.ReplicationService.DataForGet GetItemForGet(long ClientId, long SessionId) {
            return base.Channel.GetItemForGet(ClientId, SessionId);
        }
        
        public A2.Replication.Agent.ReplicationService.PackageData GetDataForGet(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.DataForGet DataForGet) {
            return base.Channel.GetDataForGet(ClientId, SessionId, DataForGet);
        }
        
        public void SetDataForGetSent(long ClientId, long SessionId, A2.Replication.Agent.ReplicationService.DataForGet DataForGet) {
            base.Channel.SetDataForGetSent(ClientId, SessionId, DataForGet);
        }
    }
}