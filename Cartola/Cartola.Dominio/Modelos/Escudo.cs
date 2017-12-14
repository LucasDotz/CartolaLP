using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Modelos
{
    public class Escudo
    {
        public Escudo(string escudo60, string escudo45, string escudo30)
        {
            Escudo60 = escudo60;
            Escudo45 = escudo45;
            Escudo30 = escudo30;
        }
        [BsonElement("escudo60")]
        [BsonRequired()]
        public string Escudo60 { get; protected set; }
        [BsonElement("escudo45")]
        [BsonRequired()]
        public string Escudo45 { get; protected set; }
        [BsonElement("escudo30")]
        [BsonRequired()]
        public string Escudo30 { get; protected set; }
    }
}
