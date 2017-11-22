using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Cartola.Sincronizador.Base;

public class JogadorResponse
{


    [JsonProperty(PropertyName = "nome")]
    public string Nome { get; protected set; }

    [JsonProperty(PropertyName = "apelido")]
    public string Apelido { get; protected set; }

    [JsonProperty(PropertyName = "foto")]
    public string Foto { get; protected set; }

    [JsonProperty(PropertyName = "atleta_id")]
    public long Atleta { get; protected set; }

    [JsonProperty(PropertyName = "rodada_id")]
    public long Rodada { get; protected set; }

    [JsonProperty(PropertyName = "clube_id")]
    public long Clube { get; protected set; }

    [JsonProperty(PropertyName = "posicao_id")]
    public long Posicao { get; protected set; }

    [JsonProperty(PropertyName = "status_id")]
    public long Status { get; protected set; }

    [JsonProperty(PropertyName = "pontos_num")]
    public double Pontos { get; protected set; }

    [JsonProperty(PropertyName = "preco_num")]
    public double Preco { get; protected set; }

    [JsonProperty(PropertyName = "variacao_num")]
    public double Variacao { get; protected set; }

    [JsonProperty(PropertyName = "media_num")]
    public double Media { get; protected set; }

    [JsonProperty(PropertyName = "jogos_num")]
    public double Jogos { get; protected set; }


}
