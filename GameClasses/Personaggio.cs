using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public abstract class Personaggio
    {
        protected Personaggio(string nome, string salute, int exp)
        {
            Nome = nome;
            Salute = salute;
            Exp = exp;
            Inv = new Inventario();
        }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Salute { get; set; }
        [DataMember]
        public int Exp { get; set; }
        [DataMember]
        public Inventario Inv { get; set; }
        [DataMember]
        public byte[] Skin { get; set; }
    }
}