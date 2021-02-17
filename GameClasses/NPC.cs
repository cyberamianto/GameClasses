using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class NPC : Personaggio
    {
        public NPC(string nome, string salute, int exp, string desc, string amb, string frase) : base(nome, salute, exp)
        {
            Descrizione = desc;
            Amb = amb;
            Frase = frase;
        }
        [DataMember]
        public string Descrizione { get; set; }
        [DataMember]
        public string Amb { get; set; }
        [DataMember]
        public string Frase { get; set; }
    }
}