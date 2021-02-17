using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Entity
    {
        public Entity(string nome, string desc, bool racc, bool indoss)
        {
            Nome = nome;
            Descrizione = desc;
            Raccoglibile = racc;
            Indossabile = indoss;
        }
        public string Nome { get; set; } //nome entità
        public string Descrizione { get; set; } //descrizione entità
        public bool Raccoglibile { get; set; } //entità raccoglibile si/no
        public bool Indossabile { get; set; } //entità indossabile si/no
        public byte[] ImgEntity { get; set; }
    }
}