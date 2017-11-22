using Cartola.Sincronizador.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.ModelosAPIs
{
    public class Mercado : BaseModeloAPI<Mercado>
    {
        [JsonProperty(PropertyName = "atletas")]
        public List<JogadorMercado> Atletas { get; set; }

        public Mercado() : base("/atletas/mercado")
        {
            Atletas = new List<JogadorMercado>();
        }

    }
}
