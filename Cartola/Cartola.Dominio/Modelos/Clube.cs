using Cartola.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Modelos
{
    public class Clube : EntidadeBase
    {
        public string Nome { get; protected set; }

        public string Abreviacao { get; protected set; }

        public Escudo Escudos { get; protected set; }

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
