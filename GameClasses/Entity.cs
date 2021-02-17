using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class Entity
    {
        public Entity(string nome, string desc, bool racc, bool indoss)
        {
            Nome = nome;
            Descrizione = desc;
            Raccoglibile = racc;
            Indossabile = indoss;
        }
        [DataMember]
        public string Nome { get; set; } //nome entità
        [DataMember]
        public string Descrizione { get; set; } //descrizione entità
        [DataMember]
        public bool Raccoglibile { get; set; } //entità raccoglibile si/no
        [DataMember]
        public bool Indossabile { get; set; } //entità indossabile si/no
        [DataMember]
        public byte[] ImgEntity { get; set; }
    }
}