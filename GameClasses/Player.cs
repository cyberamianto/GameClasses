using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Player : Personaggio
    {
        public Player(string nome, string salute, int exp) : base(nome, salute, exp) { }
    }
}