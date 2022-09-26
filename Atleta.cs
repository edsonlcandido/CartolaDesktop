using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Cartola
{
    class Atleta
    {
        [JsonPropertyName("atleta_id")]
        public int id { get; set; }
        public int clube_id { get; set; }
        public int posicao_id { get; set; }
        public float pontos_num { get; set; }
        public float preco { get; set; }
        public float variacao { get; set; }
        public float media { get; set; }
        public float minimoParaValorizar { get; set; }
        public string slug { get; set; }
        public string apelido { get; set; }
        public string nome { get; set; }
        public int jogos_num { get; set; }
        public int status_id { get; set; }
        private int G;
        private int A;
        private int FT;
        private int FD;
        private int FF;
        private int DS;
        private int PS;
        private int FS;
        private int GC;
        private int CV;
        private int CA;
        private int PP;
        private int PC;
        private int FC;
        private int PI;
        private int I;
        private int SG;
        private int DP;
        private int DE;
        private int GS;
    }
}
