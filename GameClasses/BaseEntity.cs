using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public abstract class BaseEntity
    {
        protected BaseEntity(string nome, string desc, bool racc, bool indoss)
        {
            Nome = nome;
            Descrizione = desc;
            Raccoglibile = racc;
            Indossabile = indoss;
        }
        protected string Nome { get; set; } //nome entità
        protected string Descrizione { get; set; } //descrizione entità
        protected bool Raccoglibile { get; set; } //entità raccoglibile si/no
        protected bool Indossabile { get; set; } //entità indossabile si/no
    }
}