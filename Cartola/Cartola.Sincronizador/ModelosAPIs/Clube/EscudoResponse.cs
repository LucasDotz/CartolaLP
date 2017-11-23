using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.ModelosAPIs.Clube
{
    public class EscudoResponse
    {
        [JsonProperty(PropertyName = "60x60")]
        public string Escudo60 { get; protected set; }
        [JsonProperty(PropertyName = "45x45")]
        public string Escudo45 { get; protected set; }
        [JsonProperty(PropertyName = "30x30")]
        public string Escudo30 { get; protected set; }
    }
}
