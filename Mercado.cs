﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Cartola
{
    public class Mercado
    {
        Dictionary<int, Posicao> posicoes;
        Dictionary<int, Clube> clubes;

        public Mercado()
        {
            posicoes = new Dictionary<int, Posicao>();
            clubes = new Dictionary<int, Clube>();
        }
        public void carregaMercado()
        {
            string file = File.ReadAllText(@"mercado.json");

            JsonNode mercadoApi = JsonNode.Parse(file);

            JsonObject posicoesApi = mercadoApi["posicoes"].AsObject();

            foreach (var p in posicoesApi)
            {
                int id = Convert.ToInt32(p.Value["id"].ToString());
                Posicao posicao = new Posicao()
                {
                    nome = p.Value["nome"].ToString(),
                    id = id,
                    abreviacao = p.Value["abreviacao"].ToString()
                };

                posicoes.Add(id, posicao);
            }

            JsonDocument jsonDocument = JsonDocument.Parse(file);

            var clubesApi = jsonDocument.RootElement.GetProperty("clubes");

            foreach (var c in clubesApi.EnumerateObject())
            {
                int id = Convert.ToInt32(c.Value.GetProperty("id").ToString());
                Clube clube = JsonSerializer.Deserialize<Clube>(c.Value.ToString());
                clubes.Add(id, clube);
            }   
        }        
    }
}
