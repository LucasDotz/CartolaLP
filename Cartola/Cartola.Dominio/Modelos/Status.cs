using Cartola.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Modelos
{
    public class Status : EntidadeBase
    {
        public string Nome { get; protected set; }

        public Status(long id, string nome) : base(id)
        {
            Id = id;
            Nome = nome;
        }
    }
}
