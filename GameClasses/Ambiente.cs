using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Ambiente
    {
        protected string Nome { get; set; }
        protected string Descrizione { get; set; }
        //protected int ID { get; }
        protected int Difficoltà { get; }
        //0 = nord, 1 = est, 2 = sud, 3 = ovest
        protected bool[] Uscite;
        public Inventario InvAmbiente { get; set; }
        public Ambiente(string nome, string descrizione, int difficoltà, bool[] uscite)
        {
            Nome = nome;
            Descrizione = descrizione;
            Difficoltà = difficoltà;
            Uscite = uscite;
            InvAmbiente = new Inventario();
        }
    }
}