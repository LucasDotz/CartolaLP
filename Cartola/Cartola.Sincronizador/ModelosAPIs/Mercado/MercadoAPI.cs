using Cartola.Sincronizador.Base;
using Cartola.Sincronizador.ModelosAPIs.Clube;
using Cartola.Sincronizador.ModelosAPIs.Posicao;
using Cartola.Sincronizador.ModelosAPIs.Status;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.ModelosAPIs
{
    public class MercadoAPI : BaseModeloAPI<MercadoAPI>
    {
        [JsonProperty(PropertyName = "atletas")]
        public List<JogadorResponse> Atletas { get; set; }
        [JsonProperty(PropertyName = "clubes")]
        public Dictionary<string, ClubeResponse> Clubes;
        [JsonProperty(PropertyName = "posicoes")]
        public Dictionary<string, PosicoesResponse> Posicoes;
        [JsonProperty(PropertyName = "status")]
        public Dictionary<string, StatusResponse> Status;

        public MercadoAPI() : base("/atletas/mercado")
        {
            Atletas = new List<JogadorResponse>();
            Clubes = new Dictionary<string, ClubeResponse>();
            Posicoes = new Dictionary<string, PosicoesResponse>();
            Status = new Dictionary<string, StatusResponse>();
        }

    }
}
