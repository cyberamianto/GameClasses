using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class Arma : Entity
    {
        public Arma(string nome, string desc, int danno, int durabilità) : base(nome, desc, true, true)
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