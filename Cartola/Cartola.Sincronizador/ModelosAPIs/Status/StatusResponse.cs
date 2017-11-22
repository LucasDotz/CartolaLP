using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.ModelosAPIs.Status
{
    public class StatusResponse
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; protected set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; protected set; }
    }
}
