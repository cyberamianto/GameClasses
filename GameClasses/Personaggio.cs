using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public abstract class Personaggio
    {
        protected Personaggio(string nome, string salute, int exp)
        {
            Nome = nome;
            Salute = salute;
            Exp = exp;
            Inv = new Inventario();
        }
        public string Nome { get; set; }
        public string Salute { get; set; }
        public int Exp { get; set; }
        public Inventario Inv { get; set; }
    }
}