using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.ModelosAPIs.Clube
{
    public class ClubeResponse
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; protected set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; protected set; }

        [JsonProperty(PropertyName = "abreviacao")]
        public string Abreviacao { get; protected set; }

        //[JsonProperty(PropertyName = "posicao")]
        //public string Posicao { get; protected set; }
    }
}
