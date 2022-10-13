using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
//using System.Text.Json.Nodes;

namespace CartolaDesktop.Cartola
{
    public class Mercado
    {
        public Dictionary<int, Posicao> posicoes;
        public Dictionary<int, Clube> clubes;
        public Dictionary<int, Status> status;
        public List<Atleta> atletas;

        public Mercado()
        {
            posicoes = new Dictionary<int, Posicao>();
            clubes = new Dictionary<int, Clube>();
            status = new Dictionary<int, Status>();
            atletas = new List<Atleta>();
        }

        public void carregaMercado()
        {
            string file = File.ReadAllText(@"mercado.json");

            JsonDocument jsonDocument = JsonDocument.Parse(file);

            JsonElement posicoesApi = jsonDocument.RootElement.GetProperty("posicoes");

            foreach (var p in posicoesApi.EnumerateObject())
            {
                int id = Convert.ToInt32(p.Value.GetProperty("id").ToString());
                Posicao posicao = new Posicao()
                {
                    nome = p.Value.GetProperty("nome").ToString(),
                    id = id,
                    abreviacao = p.Value.GetProperty("abreviacao").ToString()
                };

                posicoes.Add(id, posicao);
            }

            //Usando System.Text.Json.Nodes;
            //JsonNode mercadoApi = JsonNode.Parse(file);

            //JsonObject posicoesApi = mercadoApi["posicoes"].AsObject();

            //foreach (var p in posicoesApi)
            //{
            //    int id = Convert.ToInt32(p.Value["id"].ToString());
            //    Posicao posicao = new Posicao()
            //    {
            //        nome = p.Value["nome"].ToString(),
            //        id = id,
            //        abreviacao = p.Value["abreviacao"].ToString()
            //    };

            //    posicoes.Add(id, posicao);
            //}            

            JsonElement clubesApi = jsonDocument.RootElement.GetProperty("clubes");

            foreach (var c in clubesApi.EnumerateObject())
            {
                int id = Convert.ToInt32(c.Value.GetProperty("id").ToString());
                Clube clube = JsonSerializer.Deserialize<Clube>(c.Value.ToString());
                clubes.Add(id, clube);
            }

            JsonElement statusApi = jsonDocument.RootElement.GetProperty("status");

            foreach (var s in statusApi.EnumerateObject())
            {
                int id = Convert.ToInt32(s.Value.GetProperty("id").ToString());
                Status status = JsonSerializer.Deserialize<Status>(s.Value.ToString());
                this.status.Add(id, status);
            }

            JsonElement atletasApi = jsonDocument.RootElement.GetProperty("atletas");

            foreach (var a in atletasApi.EnumerateArray())
            {
                Atleta atleta = JsonSerializer.Deserialize<Atleta>(a.ToString());
                var scouts = a.GetProperty("scout");
                atleta.scout = JsonSerializer.Deserialize<Scout>(scouts.ToString());
                //foreach (PropertyInfo property in atleta.scout.GetType().GetProperties())
                //{
                //    scouts.GetProperty(property.Name);
                //}
                atletas.Add(atleta);
            }
        }
    }
}
