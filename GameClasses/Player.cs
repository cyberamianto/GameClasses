using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class Player : Personaggio
    {
        [DataMember]
        public string AmbInit { get; set; }
        public Player(string nome, string salute, int exp, string ambInit) : base(nome, salute, exp) 
        {
            AmbInit = ambInit;
        }
    }
}