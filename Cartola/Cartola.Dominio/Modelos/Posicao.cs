using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Modelos
{
    public class Posicao
    {

        public long Id { get; protected set; }

        public string Nome { get; protected set; }

        public string Abreviacaos { get; protected set; }

        public Posicao(long id, string nome, string abreviacaos)
        {
            Id = id;
            Nome = nome;
            Abreviacaos = abreviacaos;
        }


    }
}
