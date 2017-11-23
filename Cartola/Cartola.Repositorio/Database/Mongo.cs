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
        public static IMongoDatabase Db { get; protected set; } 

        public static void Conectar()
        {
            string ConnectionString = "mongodb://127.0.0.1:27017";
            MongoClient client = new MongoClient(ConnectionString);
            Db = client.GetDatabase("Cartola");
        }





    }
}
