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

        public string Escudo60 { get; protected set; }

        public string Escudo45 { get; protected set; }

        public string Escudo30 { get; protected set; }
    }
}
