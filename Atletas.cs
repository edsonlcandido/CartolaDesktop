using CartolaDesktop.Cartola;
using System;
using System.Collections.Generic;
using System.Text;

namespace CartolaDesktop
{
    internal class Atletas
    {
        public Dictionary<int, Posicao> posicoes ;
        public Dictionary<int, Clube> clubes;
        public Dictionary<int, Status> dictStatus;
        public List<Atleta> atletas;
        List<Atletas> _edinhoAtletas;
        public string apelido { get; set; }
        public string status { get; set; }
        public string clube { get; set; }
        public string posicao { get; set; }
        public double preco { get; set; }
        public double ultima { get; set; }
        public double minValorizar { get; set; }
        public double media { get; set; }
        public int rodadas { get; set; }
        public int G { get; set; }
        public int A { get; set; }
        public int FT { get; set; }
        public int FD { get; set; }
        public int FF { get; set; }
        public int DS { get; set; }
        public int PS { get; set; }
        public int FS { get; set; }
        public int GC { get; set; }
        public int CV { get; set; }
        public int CA { get; set; }
        public int PP { get; set; }
        public int PC { get; set; }
        public int FC { get; set; }
        public int PI { get; set; }
        public int I { get; set; }
        public int SG { get; set; }
        public int DP { get; set; }
        public int DE { get; set; }
        public int GS { get; set; }

        public List<Atletas> getAtletas()
        {
            foreach (var a in atletas)
            {
                Atletas eA = new Atletas();
                eA.apelido = a.apelido;
                eA.status = dictStatus[(int)a.status_id].nome;
                eA.clube = clubes[(int)a.clube_id].nome;
                eA.posicao = posicoes[(int)a.posicao_id].abreviacao;
                _edinhoAtletas.Add(eA);
            }
            return _edinhoAtletas;
        }
        public Atletas()
        {
            _edinhoAtletas = new List<Atletas>();
        }
    }
}
