using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class Ambiente
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Descrizione { get; set; }
        [DataMember]
        static int nextID;
        [DataMember]
        public int ID { get; private set; }
        [DataMember]
        public int Difficoltà { get; set; }
        [DataMember]
        public Inventario InvAmbiente { get; set; }
        [DataMember]
        public string BackgroundUrl { get; set; }
        [DataMember]
        public byte[] Background { get; set; }
        [DataMember]
        public List<NPC> npcAmb { get; set; }
        public Ambiente(string nome, string descrizione, int difficoltà, string bgPath)
        {
            Nome = nome;
            Descrizione = descrizione;
            Difficoltà = difficoltà;
            InvAmbiente = new Inventario();
            ID = System.Threading.Interlocked.Increment(ref nextID);
            BackgroundUrl = bgPath;
            npcAmb = new List<NPC>();
        }
        public Ambiente(string nome, string descrizione, int difficoltà, byte[] background)
        {
            Nome = nome;
            Descrizione = descrizione;
            Difficoltà = difficoltà;
            InvAmbiente = new Inventario();
            ID = System.Threading.Interlocked.Increment(ref nextID);
            Background = background;
            npcAmb = new List<NPC>();
        }
        public Ambiente(string nome, string descrizione, int difficoltà, string bgPath, List<NPC> npcAmbC)
        {
            Nome = nome;
            Descrizione = descrizione;
            Difficoltà = difficoltà;
            InvAmbiente = new Inventario();
            ID = System.Threading.Interlocked.Increment(ref nextID);
            BackgroundUrl = bgPath;
            npcAmb = npcAmbC;
        }
    }
}