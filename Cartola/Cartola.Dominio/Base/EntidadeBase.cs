using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Dominio.Base
{
    public abstract class EntidadeBase
    {
        public long Id { get; protected set; }
    }
}
