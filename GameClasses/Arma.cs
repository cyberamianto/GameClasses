using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Arma : EntityRaccoglibile
    {
        public Arma(string nome, string desc, int danno, int durabilità) : base(nome, desc, false)
        {
            Danno = danno;
            Durabilità = durabilità;
        }
        int Danno { get; set; }
        int Durabilità { get; set; }
    }
}