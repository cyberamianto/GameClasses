using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Player : Personaggio
    {
        public Player(string nome, int salute, int exp) : base(nome, salute, exp) { }
    }
}