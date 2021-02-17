using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class Mappa
    {
        [DataMember]
        public Ambiente[,] ambienti;
        [DataMember]
        public Player Player { get; set; }
        public Mappa(Player player)
        {
            Player = player;
            ambienti = new Ambiente[4, 4];
        }
    }
}