using Cartola.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Repositorio.Colecoes
{
    public class ClubeTable : TableBase<Clube>
    {
        public ClubeTable() : base("Clubes")
        {
        }
    }
}
