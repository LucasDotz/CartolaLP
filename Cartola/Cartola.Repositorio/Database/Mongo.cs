using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace Cartola.Repositorio.Database
{
    public class Mongo
    {
        static IMongoDatabase Db { get; set; } 

        public static IMongoDatabase Conectar()
        {
            string ConnectionString = "mongodb://127.0.0.1:27017";
            MongoClient client = new MongoClient(ConnectionString);
            Db = client.GetDatabase("Cartola");
            return Db;
        }

    }
}
