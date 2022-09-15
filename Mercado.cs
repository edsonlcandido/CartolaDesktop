using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Cartola
{
    internal class Mercado
    {
        public void carregaMercado()
        {
            var definition = new { clubes = "", posicoes = "", atletas = "", status = "" };
            string file = File.ReadAllText(@"mercado.json");

        }       
    }
}
