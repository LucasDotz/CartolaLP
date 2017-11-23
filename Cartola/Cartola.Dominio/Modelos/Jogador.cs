using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cartola.Dominio.Base;

namespace Cartola.Dominio.Modelos
{
    public class Jogador : EntidadeBase
    {
        public string Nome { get; protected set; }
        public string Apelido { get; protected set; }
        public string Foto { get; protected set; }
        public long Atleta { get; protected set; }
        //public Rodada Nome { get; protected set; }
        public Clube Clube { get; protected set; }
        public Posicao Posicao { get; protected set; }
        public Status Status { get; protected set; }
        public double Pontos { get; protected set; }
        public double Preco { get; protected set; }
        public double Variacao { get; protected set; }
        public double Media { get; protected set; }
        public double Jogos { get; protected set; }

        public Jogador(string nome, string apelido, string foto, long atleta, Clube clube, Posicao posicao, Status status, double pontos, double preco, double variacao, double media, double jogos)
            : base(atleta)
        {
            Nome = nome;
            Apelido = apelido;
            Foto = foto;
            Atleta = atleta;
            Clube = clube;
            Posicao = posicao;
            Status = status;
            Pontos = pontos;
            Preco = preco;
            Variacao = variacao;
            Media = media;
            Jogos = jogos;
        }
    }
}
