using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class NPC : Personaggio
    {
        public NPC(string nome, string salute, int exp, string desc, string amb, string frase) : base(nome, salute, exp)
        {
            Descrizione = desc;
            Amb = amb;
            Frase = frase;
        }
        string Descrizione { get; set; }
        string Amb { get; set; }
        string Frase { get; set; }
    }
}