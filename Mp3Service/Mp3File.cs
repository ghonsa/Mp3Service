using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.Data.Services;
using System.Data.Objects;
using System.Data.EntityClient;
using MongoDB.Bson;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace Mp3Service
{
    public class Mp3File
    {
        public ObjectId _id;
        public string filePath;
        public string album;
        public int track;
        public string artist;
        public string group;
        public string groupLead;
        public string interpeter;
        public string songTitle;
        public string genre;
        public string publisher;
        public string composer;
        public int year;   
    }

    public partial class MP3DataContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PhotoDataContainer object using the connection string found in the 'PhotoDataContainer' section of the application configuration file.
        /// </summary>
        public MP3DataContainer() : base("name=MP3DataContainer", "MP3DataContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PhotoDataContainer object.
        /// </summary>
        public MP3DataContainer(string connectionString) : base(connectionString, "MP3DataContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PhotoDataContainer object.
        /// </summary>
        public MP3DataContainer(EntityConnection connection) : base(connection, "MP3DataContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Mp3File> Mp3File
        {
            get
            {
                if ((_Mp3File == null))
                {
                    _Mp3File = base.CreateObjectSet<Mp3File>("Mp3File");
                }
                return _Mp3File;
            }
        }
        private ObjectSet<Mp3File> _Mp3File;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PhotoInfo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMp3Info(Mp3File mp3Info)
        {
            base.AddObject("Mp3File", mp3Info);
        }

        #endregion

    }
       
   
}