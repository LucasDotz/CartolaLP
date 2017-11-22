using Cartola.Sincronizador.ServicoRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.Base
{
    public abstract class BaseModeloAPI<T> where T : class
    {
        public const string URL = "https://api.cartolafc.globo.com";
        public virtual string Route { get;  protected set;}

        Requisitor<T> Requisitor;

        public BaseModeloAPI(string route)
        {
            Route = route;
            Requisitor = new Requisitor<T>(URL);
        }

        public T Obter()
        {
            return Requisitor.Get(Route);
        }

    }
}
