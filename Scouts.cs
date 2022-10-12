using System;
using System.Collections.Generic;
using System.Text;

namespace Cartola
{
    public class Scouts
    {
        private List<Scout> _Scouts;
        public Scouts()
        {
            Scout gol = new Scout() { id = "G", nome = "gol", pontos = 8 };
            Scout assistencia = new Scout() { id = "A", nome = "assistência", pontos = 5 };
            Scout finalizacaoTrave = new Scout() { id = "FT", nome = "finalização na trava", pontos = 3 };
            Scout finalizacaoDefendida = new Scout() { id = "FD", nome = "finalização defendida", pontos = 1.2 };
            Scout finalizacaoFora = new Scout() { id = "FF", nome = "finalização fora", pontos = 8 };
            Scout desarme = new Scout() { id = "DS", nome = "desarme", pontos = 1.2 };
            Scout penaltiSofrido = new Scout() { id = "PS", nome = "penalti sofrido", pontos = 1 };
            Scout faltaSofrida = new Scout() { id = "FS", nome = "falta sofrida", pontos = 0.5 };
            Scout golContra = new Scout() { id = "GC", nome = "gol contra", pontos = -3 };
            Scout cartaoVermelho = new Scout() { id = "CV", nome = "cartão vermelho", pontos = -3 };
            Scout cartaoAmarelo = new Scout() { id = "CA", nome = "cartão amarelo", pontos = -1 };
            Scout penaltiPerdido = new Scout() { id = "PP", nome = "penalti perdido", pontos = -4 };
            Scout penaltiCometido = new Scout() { id = "PC", nome = "penalti cometito", pontos = -1 };
            Scout faltaCometida = new Scout() { id = "FC", nome = "falta cometida", pontos = -0.3 };
            Scout passeIncompleto = new Scout() { id = "PI", nome = "passe incompleto", pontos = -0.1 };
            Scout impedimento = new Scout() { id = "I", nome = "impedimento", pontos = -0.1 };
            Scout saldoGol = new Scout() { id = "SG", nome = "saldo de gol", pontos = 5 };
            Scout defesaPenalti = new Scout() { id = "DP", nome = "defesa de penalti", pontos = 7 };
            Scout defesa = new Scout() { id = "DE", nome = "defesa", pontos = 1 };
            Scout golSofrido = new Scout() { id = "GS", nome = "gol sofrido", pontos = -1 };
        }
    }
    public struct Scout
    {
        public string id;
        public string nome;
        public double pontos;
        public double quantidade;
    }
}
