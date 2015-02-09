using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MongoDB.Bson;
using System.IO;

namespace Mp3Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMp3Service
    {

        [OperationContract]
        string GetTitle(ObjectId key);

       
        
        [OperationContract]
        Mp3File[] Index();

        [OperationContract]
        Mp3File[] GetGenre(string genre);

        [OperationContract]
        string[] Generes();


        [OperationContract]
        string[] Artists(string Genre);
       
        [OperationContract]
        string[] ALbums(string Genre,string Artist);

        [OperationContract]
        Stream GetMp3(ObjectId key);
    }


   
}
