using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class NPC : Personaggio
    {
        public NPC(string nome, int salute, int exp, string desc, int amb) : base(nome, salute, exp)
        {
            Descrizione = desc;
            Amb = amb;
        }
        string Descrizione { get; set; }
        int Amb { get; set; }
    }
}