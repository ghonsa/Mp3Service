﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mp3PlayerForms.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectId", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    [System.SerializableAttribute()]
    public partial struct ObjectId : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int _incrementField;
        
        private int _machineField;
        
        private short _pidField;
        
        private int _timestampField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _increment {
            get {
                return this._incrementField;
            }
            set {
                if ((this._incrementField.Equals(value) != true)) {
                    this._incrementField = value;
                    this.RaisePropertyChanged("_increment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _machine {
            get {
                return this._machineField;
            }
            set {
                if ((this._machineField.Equals(value) != true)) {
                    this._machineField = value;
                    this.RaisePropertyChanged("_machine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short _pid {
            get {
                return this._pidField;
            }
            set {
                if ((this._pidField.Equals(value) != true)) {
                    this._pidField = value;
                    this.RaisePropertyChanged("_pid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _timestamp {
            get {
                return this._timestampField;
            }
            set {
                if ((this._timestampField.Equals(value) != true)) {
                    this._timestampField = value;
                    this.RaisePropertyChanged("_timestamp");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Mp3File", Namespace="http://schemas.datacontract.org/2004/07/Mp3Service")]
    [System.SerializableAttribute()]
    public partial class Mp3File : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mp3PlayerForms.ServiceReference1.ObjectId _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string albumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string artistField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string composerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string filePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string groupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string groupLeadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string interpeterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string publisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string songTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int trackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yearField;
        
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
        public Mp3PlayerForms.ServiceReference1.ObjectId _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string album {
            get {
                return this.albumField;
            }
            set {
                if ((object.ReferenceEquals(this.albumField, value) != true)) {
                    this.albumField = value;
                    this.RaisePropertyChanged("album");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string artist {
            get {
                return this.artistField;
            }
            set {
                if ((object.ReferenceEquals(this.artistField, value) != true)) {
                    this.artistField = value;
                    this.RaisePropertyChanged("artist");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string composer {
            get {
                return this.composerField;
            }
            set {
                if ((object.ReferenceEquals(this.composerField, value) != true)) {
                    this.composerField = value;
                    this.RaisePropertyChanged("composer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string filePath {
            get {
                return this.filePathField;
            }
            set {
                if ((object.ReferenceEquals(this.filePathField, value) != true)) {
                    this.filePathField = value;
                    this.RaisePropertyChanged("filePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string genre {
            get {
                return this.genreField;
            }
            set {
                if ((object.ReferenceEquals(this.genreField, value) != true)) {
                    this.genreField = value;
                    this.RaisePropertyChanged("genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string group {
            get {
                return this.groupField;
            }
            set {
                if ((object.ReferenceEquals(this.groupField, value) != true)) {
                    this.groupField = value;
                    this.RaisePropertyChanged("group");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string groupLead {
            get {
                return this.groupLeadField;
            }
            set {
                if ((object.ReferenceEquals(this.groupLeadField, value) != true)) {
                    this.groupLeadField = value;
                    this.RaisePropertyChanged("groupLead");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string interpeter {
            get {
                return this.interpeterField;
            }
            set {
                if ((object.ReferenceEquals(this.interpeterField, value) != true)) {
                    this.interpeterField = value;
                    this.RaisePropertyChanged("interpeter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string publisher {
            get {
                return this.publisherField;
            }
            set {
                if ((object.ReferenceEquals(this.publisherField, value) != true)) {
                    this.publisherField = value;
                    this.RaisePropertyChanged("publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string songTitle {
            get {
                return this.songTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.songTitleField, value) != true)) {
                    this.songTitleField = value;
                    this.RaisePropertyChanged("songTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int track {
            get {
                return this.trackField;
            }
            set {
                if ((this.trackField.Equals(value) != true)) {
                    this.trackField = value;
                    this.RaisePropertyChanged("track");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int year {
            get {
                return this.yearField;
            }
            set {
                if ((this.yearField.Equals(value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMp3Service")]
    public interface IMp3Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/GetTitle", ReplyAction="http://tempuri.org/IMp3Service/GetTitleResponse")]
        string GetTitle(Mp3PlayerForms.ServiceReference1.ObjectId key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/GetTitle", ReplyAction="http://tempuri.org/IMp3Service/GetTitleResponse")]
        System.Threading.Tasks.Task<string> GetTitleAsync(Mp3PlayerForms.ServiceReference1.ObjectId key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/Index", ReplyAction="http://tempuri.org/IMp3Service/IndexResponse")]
        Mp3PlayerForms.ServiceReference1.Mp3File[] Index();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/Index", ReplyAction="http://tempuri.org/IMp3Service/IndexResponse")]
        System.Threading.Tasks.Task<Mp3PlayerForms.ServiceReference1.Mp3File[]> IndexAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/GetGenre", ReplyAction="http://tempuri.org/IMp3Service/GetGenreResponse")]
        Mp3PlayerForms.ServiceReference1.Mp3File[] GetGenre(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/GetGenre", ReplyAction="http://tempuri.org/IMp3Service/GetGenreResponse")]
        System.Threading.Tasks.Task<Mp3PlayerForms.ServiceReference1.Mp3File[]> GetGenreAsync(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/Generes", ReplyAction="http://tempuri.org/IMp3Service/GeneresResponse")]
        string[] Generes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/Generes", ReplyAction="http://tempuri.org/IMp3Service/GeneresResponse")]
        System.Threading.Tasks.Task<string[]> GeneresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/Artists", ReplyAction="http://tempuri.org/IMp3Service/ArtistsResponse")]
        string[] Artists(string Genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/Artists", ReplyAction="http://tempuri.org/IMp3Service/ArtistsResponse")]
        System.Threading.Tasks.Task<string[]> ArtistsAsync(string Genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/ALbums", ReplyAction="http://tempuri.org/IMp3Service/ALbumsResponse")]
        string[] ALbums(string Genre, string Artist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/ALbums", ReplyAction="http://tempuri.org/IMp3Service/ALbumsResponse")]
        System.Threading.Tasks.Task<string[]> ALbumsAsync(string Genre, string Artist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/GetMp3", ReplyAction="http://tempuri.org/IMp3Service/GetMp3Response")]
        System.IO.Stream GetMp3(Mp3PlayerForms.ServiceReference1.ObjectId key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMp3Service/GetMp3", ReplyAction="http://tempuri.org/IMp3Service/GetMp3Response")]
        System.Threading.Tasks.Task<System.IO.Stream> GetMp3Async(Mp3PlayerForms.ServiceReference1.ObjectId key);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMp3ServiceChannel : Mp3PlayerForms.ServiceReference1.IMp3Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Mp3ServiceClient : System.ServiceModel.ClientBase<Mp3PlayerForms.ServiceReference1.IMp3Service>, Mp3PlayerForms.ServiceReference1.IMp3Service {
        
        public Mp3ServiceClient() {
        }
        
        public Mp3ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Mp3ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Mp3ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Mp3ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetTitle(Mp3PlayerForms.ServiceReference1.ObjectId key) {
            return base.Channel.GetTitle(key);
        }
        
        public System.Threading.Tasks.Task<string> GetTitleAsync(Mp3PlayerForms.ServiceReference1.ObjectId key) {
            return base.Channel.GetTitleAsync(key);
        }
        
        public Mp3PlayerForms.ServiceReference1.Mp3File[] Index() {
            return base.Channel.Index();
        }
        
        public System.Threading.Tasks.Task<Mp3PlayerForms.ServiceReference1.Mp3File[]> IndexAsync() {
            return base.Channel.IndexAsync();
        }
        
        public Mp3PlayerForms.ServiceReference1.Mp3File[] GetGenre(string genre) {
            return base.Channel.GetGenre(genre);
        }
        
        public System.Threading.Tasks.Task<Mp3PlayerForms.ServiceReference1.Mp3File[]> GetGenreAsync(string genre) {
            return base.Channel.GetGenreAsync(genre);
        }
        
        public string[] Generes() {
            return base.Channel.Generes();
        }
        
        public System.Threading.Tasks.Task<string[]> GeneresAsync() {
            return base.Channel.GeneresAsync();
        }
        
        public string[] Artists(string Genre) {
            return base.Channel.Artists(Genre);
        }
        
        public System.Threading.Tasks.Task<string[]> ArtistsAsync(string Genre) {
            return base.Channel.ArtistsAsync(Genre);
        }
        
        public string[] ALbums(string Genre, string Artist) {
            return base.Channel.ALbums(Genre, Artist);
        }
        
        public System.Threading.Tasks.Task<string[]> ALbumsAsync(string Genre, string Artist) {
            return base.Channel.ALbumsAsync(Genre, Artist);
        }
        
        public System.IO.Stream GetMp3(Mp3PlayerForms.ServiceReference1.ObjectId key) {
            return base.Channel.GetMp3(key);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetMp3Async(Mp3PlayerForms.ServiceReference1.ObjectId key) {
            return base.Channel.GetMp3Async(key);
        }
    }
}