using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    [KnownType(typeof(Arma))]
    public class Arma : BaseEntity
    {
        public Arma(string nome, string desc, int danno, int durabilità, byte[] imgArma) : base(nome, desc, true, true, imgArma)
        {
            Danno = danno;
            Durabilità = durabilità;
        }
        [DataMember]
        public int Danno { get; set; }
        [DataMember]
        public int Durabilità { get; set; }
    }
}