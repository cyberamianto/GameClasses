using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Arma : Entity
    {
        public Arma(string nome, string desc, int danno, int durabilità) : base(nome, desc, true, true)
        {
            Danno = danno;
            Durabilità = durabilità;
        }
        int Danno { get; set; }
        int Durabilità { get; set; }
    }
}