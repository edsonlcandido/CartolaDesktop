using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Cartola
{
    internal class Mercado
    {
        class MercadoJson
        {
            public dynamic clubes { get; set; }
            public dynamic posicoes { get; set; }
            public dynamic atletas { get; set; }
            public dynamic status { get; set; }
        }

        public void carregaMercado()
        {
            var definition = new { clubes = "", posicoes = "", atletas = "", status = "" };
            string file = File.ReadAllText(@"mercado.json");
            JsonTextReader reader = new JsonTextReader(new StringReader(file));
            //while (reader.Read())
            //{
            //    if (reader.Value != null)
            //    {
            //        Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Token: {0}", reader.TokenType);
            //    }
            //}
            //JsonSerializer serializer = new JsonSerializer();
            Newtonsoft.Json.Linq.JObject mercadoJObject = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(file);
            
            MercadoJson mercadoJson = new MercadoJson();
            mercadoJson.clubes = mercadoJObject.First;
            mercadoJson.posicoes = mercadoJObject.Next;
            mercadoJson.status = mercadoJObject.Next;
            mercadoJson.atletas = mercadoJObject.Next;
        }       
    }
}
