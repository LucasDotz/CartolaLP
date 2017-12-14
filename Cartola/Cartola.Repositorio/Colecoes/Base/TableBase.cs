using Cartola.Repositorio.Database;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Repositorio.Colecoes
{
    public abstract class TableBase<T> where T : class 
    {
        public string Collection { get; protected set; }

        public TableBase(string collection)
        {
            Collection = collection;
        }

        public void Salvar(T obj)
        {
            try
            {
                var collection = Mongo.Conectar().GetCollection<T>(Collection);
                collection.InsertOne(obj);
                
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
