using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CartolaDesktop.Cartola
{
    public class Atleta
    {
        [JsonPropertyName("atleta_id")]
        public int? id { get; set; }
        public int? clube_id { get; set; }
        public int? posicao_id { get; set; }

        [JsonPropertyName("pontos_num")]
        public float? pontos { get; set; }


        [JsonPropertyName("preco_num")]
        public float? preco { get; set; }

        [JsonPropertyName("variacao_num")]
        public float? variacao { get; set; }

        [JsonPropertyName("media_num")]
        public float? media { get; set; }

        [JsonPropertyName("minimo_para_valorizar")]
        public float? minimoParaValorizar { get; set; }
        public string slug { get; set; }
        public string apelido { get; set; }
        public string nome { get; set; }
        public int? jogos_num { get; set; }
        public int? status_id { get; set; }
        public Scout scout = new Scout();
    }
}
