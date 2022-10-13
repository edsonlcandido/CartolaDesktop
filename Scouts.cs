using System;
using System.Collections.Generic;
using System.Text;

namespace Cartola
{
    public class Scouts
    {
        private List<sScout> _Scouts;

        public Scouts()
        {
            sScout gol = new sScout() { id = "G", nome = "gol", pontos = 8 };
            sScout assistencia = new sScout() { id = "A", nome = "assistência", pontos = 5 };
            sScout finalizacaoTrave =new sScout() { id = "FT", nome = "finalização na trava", pontos = 3 };
            sScout finalizacaoDefendida = new sScout() { id = "FD", nome = "finalização defendida", pontos = 1.2 };
            sScout finalizacaoFora = new sScout() { id = "FF", nome = "finalização fora", pontos = 8 };
            sScout desarme = new sScout() { id = "DS", nome = "desarme", pontos = 1.2 };
            sScout penaltiSofrido = new sScout() { id = "PS", nome = "penalti sofrido", pontos = 1 };
            sScout faltaSofrida = new sScout() { id = "FS", nome = "falta sofrida", pontos = 0.5 };
            sScout golContra = new sScout() { id = "GC", nome = "gol contra", pontos = -3 };
            sScout cartaoVermelho = new sScout() { id = "CV", nome = "cartão vermelho", pontos = -3 };
            sScout cartaoAmarelo = new sScout() { id = "CA", nome = "cartão amarelo", pontos = -1 };
            sScout penaltiPerdido = new sScout() { id = "PP", nome = "penalti perdido", pontos = -4 };
            sScout penaltiCometido = new sScout() { id = "PC", nome = "penalti cometito", pontos = -1 };
            sScout faltaCometida = new sScout() { id = "FC", nome = "falta cometida", pontos = -0.3 };
            sScout passeIncompleto = new sScout() { id = "PI", nome = "passe incompleto", pontos = -0.1 };
            sScout impedimento = new sScout() { id = "I", nome = "impedimento", pontos = -0.1 };
            sScout saldoGol = new sScout() { id = "SG", nome = "saldo de gol", pontos = 5 };
            sScout defesaPenalti = new sScout() { id = "DP", nome = "defesa de penalti", pontos = 7 };
            sScout defesa = new sScout() { id = "DE", nome = "defesa", pontos = 1 };
            sScout golSofrido = new sScout() { id = "GS", nome = "gol sofrido", pontos = -1 };
        }
    }
    public struct sScout
    {
        public string id;
        public string nome;
        public double pontos;
        public double quantidade;
    }
}
