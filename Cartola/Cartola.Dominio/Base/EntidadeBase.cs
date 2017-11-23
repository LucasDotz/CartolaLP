using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Base
{
    public abstract class EntidadeBase
    {
        //[BsonRepresentation(BsonType.ObjectId)]
        public long Id { get; protected set; }

        public EntidadeBase(long id)
        {
            Id = id;
        }
    }
}
