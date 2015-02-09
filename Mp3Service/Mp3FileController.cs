using System;
using System.Collections.Generic;
using System.Linq;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using Mp3Service;

namespace Mp3Service
{
    public class Mp3FileController 
    {
        private string connectionString = "mongodb://localhost:27017";
        // GET: Mp3File


        MongoClient client = null;
        MongoServer msrv = null ;
        MongoDatabase thedb = null; 
        MongoCollection<BsonDocument> coll = null ;

        public void Init(	)
        {
            client = new MongoClient(connectionString);
            msrv =client.GetServer();
            thedb  = msrv.GetDatabase("PrivateBook");
            coll = thedb.GetCollection("mp3Files");
        }

      

        public Mp3File Get(ObjectId key)
        {
            try
            {
               var query = (from e in coll.AsQueryable<Mp3File>()
                             where e._id == key
                             select e);
                var mp3 = query.Single();
                return mp3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public Mp3File[] Index()
        {
            try
            {
                var query = (from e in coll.AsQueryable<Mp3File>()
                              select e);

                var mp3 = query.ToArray();
                return mp3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public Mp3File[] GetGenre(string genre)
        {
            try
            {
                var query = (from e in coll.AsQueryable<Mp3File>()
                             where e.genre == genre
                             select e);

                var mp3 = query.ToArray();
                return mp3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public string[] Genres()
        {
            try
            {
                var query = (from e in coll.AsQueryable<Mp3File>()
                             select e.genre);

                var generes = query.Distinct().ToArray();
                return generes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string[] Artists(String genre)
        {
            string[] artists = null;
            try
            {
                if (genre == "")
                {
                    var query = (from e in coll.AsQueryable<Mp3File>()
                                 select e.artist);
                    artists = query.Distinct().ToArray();
                }
                else
                {
                    var query = (from e in coll.AsQueryable<Mp3File>()
                                 where e.genre == genre
                                 select e.artist);
                    artists = query.Distinct().ToArray();
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return artists;
        }
        //
        public string[] Albums(string genre, string artist)
        {
            string[] albums = null;
            try
            {
                if (genre == "" && artist == "")
                {
                    var query = (from e in coll.AsQueryable<Mp3File>()
                                 select e.album);
                    albums = query.Distinct().ToArray();
                }
                else if (genre != "" && artist == "")
                {
                    var query = (from e in coll.AsQueryable<Mp3File>()
                                 where e.genre == genre
                                 select e.album);
                    albums = query.Distinct().ToArray();
                }
                else if (genre == "" && artist != "")
                {
                    var query = (from e in coll.AsQueryable<Mp3File>()
                                 where e.artist == artist
                                 select e.album);
                    albums = query.Distinct().ToArray();
                }
                else 
                {
                    var query = (from e in coll.AsQueryable<Mp3File>()
                                 where (e.artist == artist && e.genre == genre)  
                                 select e.album);
                    albums = query.Distinct().ToArray();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return albums;
        }
    }
}