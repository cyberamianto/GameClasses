using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Mappa
    {
        public Ambiente[,] ambienti; 
        public Mappa()
        {
            ambienti = new Ambiente[4, 4];
        }
    }
}