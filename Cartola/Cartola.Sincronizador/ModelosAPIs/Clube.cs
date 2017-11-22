using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.ModelosAPIs
{
    public class Clube
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; protected set; }

        [JsonProperty(PropertyName = "nome")]
        public long Nome { get; protected set; }

        [JsonProperty(PropertyName = "abreviacao")]
        public long Abreviacao { get; protected set; }

        [JsonProperty(PropertyName = "posicao")]
        public long Posicao { get; protected set; }
    }
}
