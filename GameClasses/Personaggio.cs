using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public abstract class Personaggio
    {
        protected Personaggio(string nome, int salute, int exp)
        {
            Nome = nome;
            Salute = salute;
            Exp = exp;
        }
        protected string Nome { get; set; }
        protected int Salute { get; set; }
        protected int Exp { get; set; }
        public Inventario Inv { get; set; }
    }
}