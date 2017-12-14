using Cartola.Dominio.Base;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Modelos
{
    public class Clube : EntidadeBase
    {
        [BsonElement("nome")]
        [BsonRequired()]
        public string Nome { get; protected set; }
        [BsonElement("abreviacao")]
        [BsonRequired()]
        public string Abreviacao { get; protected set; }
        [BsonElement("escudos")]
        [BsonRequired()]
        public Escudo Escudos { get; protected set; }
        [BsonElement("jogadores")]
        [BsonRequired()]
        public List<Jogador> Jogadores { get; protected set; }

        public Clube(long id, string nome, string abreviacao, Escudo escudos)
            : base(id)
        {
            Id = id;
            Nome = nome;
            Abreviacao = abreviacao;
            Escudos = escudos;

            Jogadores = new List<Jogador>();
        }

        public void AddJogador(Jogador jogador)
        {
            Jogadores.Add(jogador);
        }
    }
}
