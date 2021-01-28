using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Ambiente
    {
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        static int nextID;
        public int ID { get; private set; }
        public int Difficoltà { get; }
        public bool[] Uscite; //0 = nord, 1 = est, 2 = sud, 3 = ovest
        public Inventario InvAmbiente { get; set; }
        public Ambiente(string nome, string descrizione, int difficoltà, bool[] uscite)
        {
            Nome = nome;
            Descrizione = descrizione;
            Difficoltà = difficoltà;
            Uscite = uscite;
            InvAmbiente = new Inventario();
            ID = System.Threading.Interlocked.Increment(ref nextID);
        }
    }
}