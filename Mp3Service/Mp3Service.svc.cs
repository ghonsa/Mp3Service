using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using MongoDB.Bson;

namespace Mp3Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Mp3Service : IMp3Service
    {
       
        public string GetTitle(ObjectId key)
        {
            Mp3FileController ctrl = new Mp3FileController();
            ctrl.Init();
            var mp3File = ctrl.Get(key);
            return mp3File.songTitle;
        }
        public Mp3File[] Index()
        {
            Mp3FileController ctrl = new Mp3FileController();
             ctrl.Init();
             return ctrl.Index();
        }
        public Mp3File[] GetGenre(string genre)
        {
            Mp3FileController ctrl = new Mp3FileController();
            ctrl.Init();
            return ctrl.GetGenre(genre);
        }
        public string[] Generes()
        {
            Mp3FileController ctrl = new Mp3FileController();
            ctrl.Init();
            return ctrl.Genres();
        }

        public string[] Artists(string Genre)
        {
            Mp3FileController ctrl = new Mp3FileController();
            ctrl.Init();
            return ctrl.Artists(Genre);
        }


        public string[] ALbums(string Genre, string Artist)
        {
            Mp3FileController ctrl = new Mp3FileController();
            ctrl.Init();
            return ctrl.Albums(Genre,Artist);
        }

        public Stream GetMp3(ObjectId key)
        {
            Mp3FileController ctrl = new Mp3FileController();
            ctrl.Init();
            var mp3File = ctrl.Get(key);
       
            string fullMp3FilePath = mp3File.filePath;

            if (!File.Exists(fullMp3FilePath))
            {
                throw new Exception( "The mp3 could not be found.");
            }

            // Return a stream that contains the requested file.
            return new FileStream(fullMp3FilePath, FileMode.Open);
        }
    }
}
