using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class MappaVett
    {
        [DataMember]
        public Ambiente[] ambienti;
        [DataMember]
        public Player Player { get; set; }
        public MappaVett(Ambiente[] amb, Player player)
        {
            Player = player;
            ambienti = amb;
        }
    }
}
