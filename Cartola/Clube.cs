using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CartolaDesktop.Cartola
{
    public class Clube
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string abreviacao { get; set; }
        [JsonPropertyName("nome_fantasia")]
        public string nomeFantasia { get; set; }
    }
}
