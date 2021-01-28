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
        public Inventario InvAmbiente { get; set; }
        public System.Drawing.Image backGroung { get; set; }
        public Ambiente(string nome, string descrizione, int difficoltà)
        {
            Nome = nome;
            Descrizione = descrizione;
            Difficoltà = difficoltà;
            InvAmbiente = new Inventario();
            ID = System.Threading.Interlocked.Increment(ref nextID);
        }
    }
}