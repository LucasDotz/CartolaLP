using Cartola.Repositorio.Database;
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

        public async void Salvar(T obj)
        {
            var collection = Mongo.Conectar().GetCollection<T>(Collection);
            await collection.InsertOneAsync(obj);
        }
    }
}
