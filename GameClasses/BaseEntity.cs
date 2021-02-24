using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public abstract class BaseEntity
    {
        public BaseEntity(string nome, string desc, bool racc, bool indoss, byte[] imgEntity)
        {
            Nome = nome;
            Descrizione = desc;
            Raccoglibile = racc;
            Indossabile = indoss;
            ImgEntity = imgEntity;
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
